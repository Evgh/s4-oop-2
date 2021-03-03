using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace s4_oop_2
{
    // структура для передачи параметров в конструктор Flat
    public struct FlatArgs
    {
        public string owner; //1 
        public int residentAmount; //2
        public int area; //3
        public DateTime day; // 5     
        public bool hasKitchen; //6
        public bool hasBathroom; //7 
        public bool hasRestroom; //8
        public bool hasBasement; //9
        public bool hasBalcony; //10       
        public Adress adress; //11

        public FlatArgs(string str = "Def")
        {
            owner = "Владелец";
            residentAmount = 1;
            area = 100;
            day = DateTime.Now;
            hasKitchen = true;
            hasBathroom = true;
            hasRestroom = true;
            hasBasement = false;
            hasBalcony = false;
            adress = Adress.GetAdress(0);
        }
    }

    public interface IFlat
    {
        //0
        int Id { get; }
        //1
        [Required]
        [StringLength(30, MinimumLength = 7, ErrorMessage = "0: Не бывает имен меньше 7 символов и больше 30")]
        string Owner { get; set; }
        //2
        int ResidentAmount { get; set; }
        //3
        [Required]
        [Range(1, 750, ErrorMessage = "1: Не положено иметь квартиры больше 750 и меньше 1 квадратного метра, потому что в нашей стране нет настолько богатых или настолько бедных людей")]
        int Area { get; set; }
        //4
        int RoomAmount { get; }
        //5
        DateTime Day { get; set; }
        //6
        bool HasKitchen { get; set; }
        //7
        bool HasBathroom { get; set; }
        //8
        bool HasRestroom { get; set; }
        //9
        bool HasBasement { get; set; }
        //10
        bool HasBalcony { get; set; }

        //11
        // агрегация объекта адреса
        int AdressId { get; set; }
        // 12
        Adress FlatAdress { get; set; }

        List<Room> Rooms { get; }
        void InitializeRooms(List<Room> rooms);

        double Price { get; }
        double GetPrice();
    }


    [Serializable]
    public class SimpleFlat : IFlat 
    {
        protected static int idGiver = 0;
        //0
        public int Id { get; }
        //1
        [Required]
        [StringLength(30, MinimumLength = 7, ErrorMessage = "0: Не бывает имен меньше 7 символов и больше 30")]
        public string Owner { get; set; }
        //2
        public int ResidentAmount { get; set; }
        //3
        [Required]
        [Range(11, 750, ErrorMessage = "1: Не положено иметь квартиры больше 750 и меньше 11 квадратных метров, потому что в нашей стране нет настолько богатых или настолько бедных людей")]
        public int Area { get; set; }
        //4
        public int RoomAmount { get => _rooms.Count; }
        //5
        public DateTime Day { get; set; }
        //6
        public bool HasKitchen { get; set; }
        //7
        public bool HasBathroom { get; set; }
        //8
        public bool HasRestroom { get; set; }
        //9
        public bool HasBasement { get; set; }
        //10
        public bool HasBalcony { get; set; }

        //11
        // агрегация объекта адреса
        public int AdressId { get; set; }
        // 12
        public Adress FlatAdress { get => Adress.adressPool[AdressId]; set => AdressId = value.Id; }

        // композиция объектов-комнат
        [JsonIgnore]
        public List<Room> Rooms { get => _rooms; } 
        public List<Room> _rooms;

        [JsonIgnore]
        public double Price => GetPrice();

        public SimpleFlat(string owner, int residentAmount, int area, DateTime day, bool hasKitchen, bool hasBathroom, bool hasRestroom, bool hasBasement, bool hasBalcony, Adress adress)
        {
            Owner = owner;
            ResidentAmount = residentAmount;
            Area = area;
            Day = day;
            HasKitchen = hasKitchen;
            HasBathroom = hasBathroom;
            HasRestroom = hasRestroom;
            HasBasement = hasBasement;
            HasBalcony = hasBalcony;

            Id = idGiver++;
            AdressId = adress.Id;
        }

        protected SimpleFlat() : this("Владелец", 1, 100, DateTime.Now, true, true, true, false, false, Adress.GetAdress(0))
        {

        }
        public SimpleFlat(FlatArgs fa) : this(fa.owner, fa.residentAmount, fa.area, fa.day, fa.hasKitchen, fa.hasBathroom, fa.hasRestroom, fa.hasBasement, fa.hasBalcony, fa.adress)
        {

        }

        public SimpleFlat(int index)
        {
            Id = index;
        }


        public void InitializeRooms(List<Room> rooms)
        {
            _rooms = rooms;
        }

        public virtual double GetPrice()
        {
            return Area * 29 * (4.7 / (0.1 * (_rooms.Count + 1)));
        }
    }

    public class SuperFlat : SimpleFlat, IFlat
    {
        public SuperFlat(FlatArgs fa) : base(fa) { }
    }

    public static class FlatDirector
    {
        public static IFlat CreateFlat(FlatBuilder flatBuilder)
        {
            flatBuilder.CreateFlat();
            flatBuilder.InitializeRooms();
            return flatBuilder.GetFlat;
        }
    }

    public abstract class FlatBuilder
    {
        protected IFlat activeFlat;
        public IFlat GetFlat => activeFlat;

        protected FlatArgs flatArgs;

        public abstract void CreateFlat();
        public abstract void InitializeRooms();
    }

    public class SimpleFlatBuilder : FlatBuilder
    {
        public SimpleFlatBuilder(FlatArgs fa)
        {
            flatArgs = fa;
        }
        public override void CreateFlat()
        {
            activeFlat = new SimpleFlat(flatArgs);
        }
        public override void InitializeRooms()
        {
            activeFlat.InitializeRooms(new List<Room> { });
        }
    }

    public class SuperFlatBuilder : FlatBuilder
    {
        public SuperFlatBuilder(FlatArgs fa)
        {
            flatArgs = fa;
        }
        public override void CreateFlat()
        {
            activeFlat = new SuperFlat(flatArgs);
        }
        public override void InitializeRooms()
        {
            List<Room> rooms = new List<Room> { };
            int freeArea = activeFlat.Area;

            Random rand = new Random();
            int roomsAmount = rand.Next(1, 6);

            for (int i = 1; i <= roomsAmount && freeArea > 0; i++)
            {
                int roomArea;
                int roomWindows;
                Room.RoomOrientation roomOrientation;

                roomArea = i < roomsAmount ? rand.Next(1, freeArea) : freeArea;
                freeArea -= roomArea;

                roomOrientation = (Room.RoomOrientation)rand.Next(0, 7);
                roomWindows = rand.Next(0, 4);

                rooms.Add(new Room(roomArea, roomWindows, roomOrientation));
            }

            activeFlat.InitializeRooms(rooms);
        }
    }
}