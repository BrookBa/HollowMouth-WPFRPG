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
        internal static Region CreateRegion(int region)
        {
            Region r = new Region();
            switch (region) 
            {
                case CONSTANTS.WORLD:
                    {
                        r.Name = "World";
                        r.AddLocation(new Location(0, 0,
                            "Hollow Mouth Island", "A deserted island adrift between two towns, isolated by the lake; a strange stone sits at the center--maybe it used to belong to a lighthouse?",
                            "/Engine;component/Resources/Images/Locations/island.jpg"));
                        r.LocationAt(0, 0).addDoor(new RegionDoor(CONSTANTS.HOLLOWMOUTH, 0, -1, CONSTANTS.DOCKHERE));
                        r.AddLocation(new Location(-1, 0,
                            "The Endless Lake", "A glassy-surfaced lake that stretches out seemingly beyond the horizon--perhaps it does indeed have an end, somewhere out there…",
                            "/Engine;component/Resources/Images/Locations/Lake.jpg"));
                        r.LocationAt(-1, 0).addDoor(new RegionDoor(CONSTANTS.LAKE, 0, 0, CONSTANTS.SAILHERE));
                        r.AddLocation(new Location(0, -1,
                            "Fall Hollow", "A bustling, vibrant town that enjoys warm weather and whatever the forest decides to gift them.",
                            "/Engine;component/Resources/Images/Locations/FVDocks.jpg"));

                        r.LocationAt(0, -1).addDoor(new RegionDoor(CONSTANTS.FALLHOLLOW, 0, -2, CONSTANTS.DOCKHERE));
                        r.AddLocation(new Location(1, 0,
                            "The Abundant Forest", "A virdent forest, teaming with flora and fauna, the trees reach right to the edge of the lake--beyond the first line of trees, however, is obscured in shadow.",
                            "/Engine;component/Resources/Images/Locations/Forest.jpg"));
                        r.LocationAt(1, 0).addDoor(new RegionDoor(CONSTANTS.FOREST, 0, 0, CONSTANTS.DOCKHERE));
                        r.AddLocation(new Location(0, 1,
                            "Raven's Hollow", "An industrial town dressed in austere colors and cool weather--every season can be a rainy season in Raven's Hollow.",
                            "/Engine;component/Resources/Images/Locations/NVDocks.jpg"
                            ));
                        r.LocationAt(0, 1).addDoor(new RegionDoor(CONSTANTS.RAVENSHOLLOW, 0, -3, CONSTANTS.DOCKHERE));
                        return r;
                    }
                case CONSTANTS.HOLLOWMOUTH:
                    {
                        r.Name = "Hollow Mouth Island";
                        r.AddLocation(new Location(0, -1,
                            "The Dock", "An old, worn out dock that's seen better days; you should mind your step, it looks a bit rickety.",
                            "/Engine;component/Resources/Images/Locations/NVDocks.jpg"
                            ));
                        r.LocationAt(0, -1).addDoor(new RegionDoor(CONSTANTS.WORLD, 0, 0, CONSTANTS.BOARDBOAT));

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
                
                case CONSTANTS.RAVENSHOLLOW:
                    {
                        r.Name = "Raven's Hollow";
                        r.AddLocation(new Location(0, -3,
                             "Raven's Hollow Docks", "The blackened planks groan beneath you as you step onto the docks; the lake silent below you as it sleeps.",
                             "/Engine;component/Resources/Images/Locations/island.jpg"
                             ));

                        r.LocationAt(0, -3).addDoor(new RegionDoor(CONSTANTS.WORLD, 0, 1, CONSTANTS.BOARDBOAT));
                        return r;
                    }
                case CONSTANTS.FALLHOLLOW:
                    {
                        r.Name = "Fall Hollow";
                        r.AddLocation(new Location(0, -2,
                            "The Docks", "The sun-bleached planks creak in greeting as you step onto the dock, the lake lapping softly against the pillars beneath you.",
                            "/Engine;component/Resources/Images/Locations/island.jpg"
                            ));
                        r.LocationAt(0, -2).addDoor(new RegionDoor(CONSTANTS.WORLD, 0, -1, CONSTANTS.BOARDBOAT));
                        r.AddLocation(new Location(0, -1,
                            "Standing Stones", "Six tall stones stand in a circle, irregular in shape and height, and the path cuts through the center. Maybe it would be best not to linger here…",
                            "/Engine;component/Resources/Images/Locations/island.jpg"
                            ));
                        r.AddLocation(new Location(0, 0,
                            "Town Square", "A vibrant, cobble-stoned square sits at the center of town, filled to bursting with bright flowers.",
                            "/Engine;component/Resources/Images/Locations/island.jpg"
                            ));
                        r.AddLocation(new Location(-1, 0,
                            "Market", "A collection of stalls are huddled together around the marketspace, with little lights and colored ribbons strung between their roofs.",
                            "/Engine;component/Resources/Images/Locations/island.jpg"
                            ));
                        r.AddLocation(new Location(-1, -1,
                            "Rise & Shine", "The scent of fresh-from-the-oven bread wafts from the stall as you approach, the display packed with mouth-watering pasteries--both savory and sweet.",
                            "/Engine;component/Resources/Images/Locations/island.jpg"
                            ));
                        r.AddLocation(new Location(-2, -1,
                            "Curious Companions", "The stall is more a conglomerate of cages and crates than it is an actual structure, but the creatures housed therein blink and wink and stare very calmly as you approach.",
                            "/Engine;component/Resources/Images/Locations/island.jpg"
                            ));
                        r.AddLocation(new Location(-2, 0,
                            "All Seasons Outfitters", "The Outfitters stall is packed with brightly colored clothing and accessories, as well as few more somber pieces, tucked away at the back.",
                            "/Engine;component/Resources/Images/Locations/island.jpg"
                            ));
                        r.AddLocation(new Location(-2, 1,
                            "Nick's Knack Wagon", "The old, covered wagon has a crooked, handpainted sign hanging from the door, and steps that lead up into the packed interior.",
                            "/Engine;component/Resources/Images/Locations/island.jpg"
                            ));
                        r.AddLocation(new Location(-2, -2,
                             "The Forest Spirit", "Herbs are hung out to dry around the frame of the herbalist's stall, strung on colored ribbon and neatly labeled, inviting customers to come closer and investigate.",
                             "/Engine;component/Resources/Images/Locations/island.jpg"
                             ));
                        r.AddLocation(new Location(0, -2,
                             "", "",
                             "/Engine;component/Resources/Images/Locations/island.jpg"
                             ));
                        

                        return r;
                    }
                case CONSTANTS.LAKE:
                    {
                        r.Name = "The Endless Lake";
                        r.AddLocation(new Location(0, 0,
                             "The Bouy", "No matter how far you row, it seems to always stay in your peripheral vision.",
                             "/Engine;component/Resources/Images/Locations/island.jpg"
                             ));

                        r.LocationAt(0, 0).addDoor(new RegionDoor(CONSTANTS.WORLD, -1, 0, CONSTANTS.SAILHERE));
                        return r;
                    }
                case CONSTANTS.FOREST:
                    {
                        r.Name = "The Abundant Forest";
                        r.AddLocation(new Location(0, 0,
                             "The Tower", "The spire pierces the canopy of the forest, making it visible from long distances away. Circling it, you cannot find an entrance.",
                             "/Engine;component/Resources/Images/Locations/island.jpg"
                             ));

                        r.LocationAt(0, 0).addDoor(new RegionDoor(CONSTANTS.WORLD, 1,0, CONSTANTS.BOARDBOAT));
                        return r;
                    }

            }
            return r;
        }
    }
}
