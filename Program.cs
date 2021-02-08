using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace s4_oop_2
{

    public class Adress
    {
        // хранилище всех созданных адресов. программа не позволяет создавать отдельно взятые адреса, вся работа производится через статический пул
        public readonly static List<Adress> adressPool; 

        static int nextId = 0;
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public int FlatNumber { get; set; }
        public int Id { get; set; }

        // свойство для отображения в листбоксе на Form1
        public string MyToString
        {
            get => ToString();
        }

        Adress(string country, string city, string district, string street, string houseNum, int flatNum)
        {
            Country = country;
            City = city;
            District = district;
            Street = street;
            HouseNumber = houseNum;
            FlatNumber = flatNum;

            Id = nextId++;
        }
        Adress() : this("country", "city", "district", "Street", "61A", 13)
        {

        }
        static Adress()
        {
            adressPool = new List<Adress> { new Adress() };
        }

        public override string ToString()
        {
            return $"{Country}, г. {City}, район {District}, ул. {Street}, {HouseNumber}-{FlatNumber}";
        }
               
        // Статические методы для взаимодействия с пулом адресов. 
        public static void Add()
        {
            adressPool.Add(new Adress());
        }

        public static void Add(string country, string city, string district, string street, string houseNum, int flatNum)
        {
            adressPool.Add(new Adress(country, city, district, street, houseNum, flatNum));
        }

        public static Adress GetAdress(int index)
        {
            return adressPool[index];
        }
    }

    class Room
    {
        public int Area { get; set; }
        public int Windows { get; set; }
        public int Orientation { get; set; }
    }

    // структура для передачи параметров в конструктор Flat
    public struct FlatArgs
    {
        public string owner; //1 
        public int residentAmount; //2
        public int area; //3
        public int roomAmount; //4 
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
        public string Owner { get; set; } //1
        public int ResidentAmount { get; set; } //2
        public int Area { get; set; } //3
        public int RoomAmount { get; set; } //4
        public DateTime Day { get; set; } //5
        public bool HasKitchen { get; set; } //6
        public bool HasBathroom { get; set; } //7
        public bool HasRestroom { get; set; } //8
        public bool HasBasement { get; set; } //9
        public bool HasBalcony { get; set; } //10
        public int AdressId { get; set; }

        
        // агрегация объекта адреса
        public string AdressStr { get => (Adress.adressPool[AdressId]).ToString(); }

        // композиция объектов-комнат
        //public List<Room> rooms; 
        // функционал с комнатами добавлю позже

        public Flat(string owner, int residentAmount, int area, int roomAmount, DateTime day, bool hasKitchen, bool hasBathroom, bool hasRestroom, bool hasBasement, bool hasBalcony, Adress adress)
        {
            Owner = owner;
            ResidentAmount = residentAmount;
            Area = area;
            RoomAmount = roomAmount;
            Day = day;
            HasKitchen = hasKitchen;
            HasBathroom = hasBathroom;
            HasRestroom = hasRestroom;
            HasBasement = hasBasement;
            HasBalcony = hasBalcony;
            AdressId = adress.Id;
            //rooms = new List<Room> { };
        }
        public Flat() : this("Владелец", 1, 100, 1, DateTime.Now, true, true, true, false, false, Adress.GetAdress(0))
        {

        }
        public Flat(FlatArgs fa) : this(fa.owner, fa.residentAmount, fa.area, fa.roomAmount, fa.day, fa.hasKitchen, fa.hasBathroom, fa.hasRestroom, fa.hasBasement, fa.hasBalcony, fa.adress)
        {

        }
    }

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Adress.Add("Бел", "Минск", "Центр", "Захарова", "61", 13);
            Adress.Add("Пшекия", "Пшексити", "Экстремисткий", "Путило", "8", 9);
            Adress.Add("Украина", "Киiв", "Киiв", "Слава", "3", 5);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1( new List<Flat> { new Flat(), new Flat() }));
        }
    }
}
