using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s4_oop_2
{
    public class Room
    {
        public enum RoomOrientation
        {
            North, South, East, West, NorthEast, NorthWest, SouthEast, SouthWest
        }

        public int Area { get; set; }
        public int Windows { get; set; }
        public RoomOrientation Orientation { get; set; }

        public override string ToString()
        {
            return $"Комната в {Area} метров выходит на {Orientation} {Windows} окнами";
        }
        public Room(int area, int windows, RoomOrientation orientation)
        {
            Area = area;
            Windows = windows;
            Orientation = orientation;
        }

        public Room() : this(10, 1, RoomOrientation.North)
        {

        }
    }
}
