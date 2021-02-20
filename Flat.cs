using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
    }

    [Serializable]
    public class Flat
    {
        static int idGiver = 0;
        
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
        [Range(1, 750, ErrorMessage = "1: Не положено иметь квартиры больше 750 и меньше 1 квадратного метра, потому что в нашей стране нет настолько богатых или настолько бедных людей")]
        public int Area { get; set; }
        //4
        public int RoomAmount { get => rooms.Count; }
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
        //public string AdressStr { get => (Adress.adressPool[AdressId]).ToString(); }

        // 12
        public Adress FlatAdress { get => Adress.adressPool[AdressId]; set => AdressId = value.Id; }



        // композиция объектов-комнат
        public List<Room> rooms = new List<Room> { };

        public Flat(string owner, int residentAmount, int area, DateTime day, bool hasKitchen, bool hasBathroom, bool hasRestroom, bool hasBasement, bool hasBalcony, Adress adress)
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
        public Flat() : this("Владелец", 1, 100, DateTime.Now, true, true, true, false, false, Adress.GetAdress(0))
        {

        }
        public Flat(FlatArgs fa) : this(fa.owner, fa.residentAmount, fa.area, fa.day, fa.hasKitchen, fa.hasBathroom, fa.hasRestroom, fa.hasBasement, fa.hasBalcony, fa.adress)
        {
        }

        public double Count()
        {
            return Area * 29 * (4.7 / (0.1 * (rooms.Count + 1)));
        }
    }

}