using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class RegionDoor
    {
        public int RegionCode { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public string DoorText { get; set; }
        public RegionDoor(int code, int x, int y, string doorText)
        {
            RegionCode = code;
            X = x;
            Y = y;
            DoorText = doorText;
        }
    }
}
