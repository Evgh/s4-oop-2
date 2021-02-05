using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s4_oop_2
{

    class Adress
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public int FlatNumber { get; set; }
    }

    class Room
    {
        public int Area { get; set; }
        public int Windows { get; set; }
        public int Orientation { get; set; }
    }

   

    class Flat
    {
        public string Owner { get; set; }
        public int ResidentAmount { get; set; }
        public int Area { get; }
        public int RoomAmount { get; }
        public DateTime Day { get; set; }
        public bool HasKitchen { get; set; }
        public bool HasBathroom { get; set; }
        public bool HasRestroom { get; set; }
        public bool HasBasement { get; }
        public bool HasBalcony { get; }
        


        // агрегируемые объекты 
        public Adress Adress { get; set; }

        // функционал с комнатами добавлю позже
        //public List<Room> rooms; 

        public Flat(int area, int roomAmount, bool hasKitchen, bool hasBathroom, bool hasRestroom, bool hasBasement, bool hasBalcony, int residentAmount)
        {
            Area = area;
            RoomAmount = roomAmount;
            HasKitchen = hasKitchen;
            HasBathroom = hasBathroom;
            HasRestroom = hasRestroom;
            HasBasement = hasBasement;
            HasBalcony = hasBalcony;

            ResidentAmount = residentAmount;

            //rooms = new List<Room> { };
        }

        public Flat() : this(100, 1, true, true, true, true, true, 1)
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
            Application.Run(new Form1());
        }
    }
}
