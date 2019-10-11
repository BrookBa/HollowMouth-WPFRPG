using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class World
    {
        public enum Regions
        {
            World,
            HollowMouth,
            RavensHollow,
            FallHollow,
            Lake,
            Forest
        }

        private List<Region> _regions = new List<Region>();
        internal void AddRegion(Regions regionKey, Region ToAdd)
        {
            _regions.Insert((int)regionKey, ToAdd);
        }

        public Region GetRegion(Regions regionKey)
        {
            return _regions[(int)regionKey];
        }
        
    }
}
