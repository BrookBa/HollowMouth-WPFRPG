using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal static class RegionFactory
    {
        internal static Region CreateRegion(string RegionName)
        {
            Region r = new Region
            {
                Name = RegionName
            };
            switch (RegionName) 
            {
                case "HollowMouth":
                    {
                        r.AddLocation(new Location(0, -1,
                            "The Dock", "An old, worn out dock that's seen better days; you should mind your step, it looks a bit rickety.",
                            "/Engine;component/Resources/Images/Locations/NVDocks.jpg"
                            ));
                        r.AddLocation(new Location(0,0,
                            "The Beacon", "A strange stone with a hole carved near the top, clean through it; you feel drawn to it, somehow…",
                            "/Engine;component/Resources/Images/Locations/island.jpg"
                            ));
                        r.AddLocation(new Location(0,1,
                            "The Shack", "A run down little shack, serviceable, but not ideal; you could probably sleep here, if you had to.",
                            "/Engine;component/Resources/Images/Locations/island.jpg"
                            ));
                        r.AddLocation(new Location(-1, 0,
                            "The Shoreline", "Black sand is dotted with small shells and seaglass, leading down to the still waters of the lake.",
                            "/Engine;component/Resources/Images/Locations/island.jpg"
                            ));
                        r.AddLocation(new Location(1, 0,
                            "The Cliffs", "Jagged white stone peeks from the side of the island, a short drop into the lake; but there's no telling what waits below in the water.",
                            "/Engine;component/Resources/Images/Locations/island.jpg"
                            ));
                        return r;
                    }
                case "World":
                    {
                        r.AddLocation(new Location(0, 0,
                            "Hollow Mouth Island", "A deserted island adrift between two towns, isolated by the lake; a strange stone sits at the center--maybe it used to belong to a lighthouse?",
                            "/Engine;component/Resources/Images/Locations/island.jpg"));
                        r.AddLocation(new Location(-1, 0,
                            "The Endless Lake", "A glassy-surfaced lake that stretches out seemingly beyond the horizon--perhaps it does indeed have an end, somewhere out there…",
                            "/Engine;component/Resources/Images/Locations/Lake.jpg"));
                        r.AddLocation(new Location(0, 1,
                            "Fall Hollow", "A bustling, vibrant town that enjoys warm weather and whatever the forest decides to gift them.",
                            "/Engine;component/Resources/Images/Locations/FVDocks.jpg"));
                        r.AddLocation(new Location(1, 0,
                            "The Abundant Forest", "A virdent forest, teaming with flora and fauna, the trees reach right to the edge of the lake--beyond the first line of trees, however, is obscured in shadow.",
                            "/Engine;component/Resources/Images/Locations/Forest.jpg"));
                        r.AddLocation(new Location(0, 1,
                            "Raven's Hollow", "An industrial town dressed in austere colors and cool weather--every season can be a rainy season in Raven's Hollow.",
                            "/Engine;component/Resources/Images/Locations/NVDocks.jpg"
                            ));
                        return r;
                    }
                case "RavensHollow":
                    {
                        return r;
                    }
            }
            return r;
        }
    }
}
