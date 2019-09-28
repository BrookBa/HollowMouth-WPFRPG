using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class World
    {
        private List<Region> _regions = new List<Region>();
        internal void AddRegion(Region ToAdd)
        {
            _regions.Add(ToAdd);
        }

        public Region GetRegion(int regionKey)
        {
            return _regions[regionKey];
        }
        
    }
}
