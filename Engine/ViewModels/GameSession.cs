using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.ViewModels
{
    public class GameSession: BaseNotificationClass
    {
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentLocation = new Location
            {
                XCoordinate = 0,
                YCoordinate = 0,
                Name = "Island",
                Description = "You woke up here",
                ImageName = "/Engine;component/Resources/Images/Locations/island.jpg"
            };
        }
    }
}
