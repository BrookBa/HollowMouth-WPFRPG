using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Region
    {
        private List<Location> _locations = new List<Location>();
        public string Name;
        internal void AddLocation(Location toAdd)
        {
            _locations.Add(toAdd);
        }

        internal Location LocationAt(int x, int y)
        {
            foreach(Location loc in _locations)
            {
                if(loc.XCoordinate == x && loc.YCoordinate == y)
                {
                    return loc;
                }
            }
            return null;
        }
    }
}
