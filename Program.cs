using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s4_oop_2
{

    public class Adress
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public int FlatNumber { get; set; }

        public string MyToString
        {
            get => ToString();
        }
        public override string ToString()
        {
            return $"{Country}, г. {City}, район {District}, ул. {Street}, {HouseNumber}-{FlatNumber}";
        }

        public Adress (string country, string city, string district, string street, string houseNum, int flatNum)
        {
            Country = country;
            City = city;
            District = district;
            Street = street;
            HouseNumber = houseNum;
            FlatNumber = flatNum;
        }

        public Adress() : this ("country", "city", "district", "Street", "61A", 13)
        {

        }
    }

    class Room
    {
        public int Area { get; set; }
        public int Windows { get; set; }
        public int Orientation { get; set; }
    }

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


        // агрегируемые объекты 
        Adress _adress; //11
        public string Adress { get => _adress.ToString();}

        // функционал с комнатами добавлю позже
        //public List<Room> rooms; 

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

            _adress = adress;
            //rooms = new List<Room> { };
        }

        public Flat() : this("Владелец", 1, 100, 1, DateTime.Now, true, true, true, false, false, new Adress())
        {

        }
        public Flat (FlatArgs fa) : this(fa.owner, fa.residentAmount, fa.area, fa.roomAmount, fa.day, fa.hasKitchen, fa.hasBathroom, fa.hasRestroom, fa.hasBasement, fa.hasBalcony, fa.adress)
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1( new List<Flat> { new Flat(), new Flat() }, new List<Adress> { new Adress(), new Adress(), new Adress()}));
        }
    }
}
