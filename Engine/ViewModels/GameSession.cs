using Engine.Factories;
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
        private Location _currentLocation;
        public Location CurrentLocation
        {
            get { return _currentLocation; }
            set
            {
                _currentLocation = value;
                OnPropertyChanged(nameof(CurrentLocation));
                OnPropertyChanged(nameof(HasLocationToEast));
                OnPropertyChanged(nameof(HasLocationToWest));
                OnPropertyChanged(nameof(HasLocationToNorth));
                OnPropertyChanged(nameof(HasLocationToSouth));
                OnPropertyChanged(nameof(HasDoor));
                OnPropertyChanged(nameof(CurrentLocation.Door.DoorText));

            }
        }
        public Region CurrentRegion { get; set; }
        public World CurrentWorld { get; set; }
        public bool HasLocationToNorth
        {
            get
            {
                return null !=CurrentRegion.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate+1) ;

            }
        }
        public bool HasLocationToSouth
        {
            get
            {
                return null != CurrentRegion.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate-1);

            }
        }
        public bool HasLocationToEast
        {
            get
            {
                return null != CurrentRegion.LocationAt(CurrentLocation.XCoordinate+1, CurrentLocation.YCoordinate);

            }
        }
        public bool HasLocationToWest
        {
            get
            {
                return null != CurrentRegion.LocationAt(CurrentLocation.XCoordinate-1, CurrentLocation.YCoordinate);

            }
        }
        public bool HasDoor
        {
            get
            {
                return CurrentLocation.Door !=null;
            }
        }

        public GameSession()
        {
            CurrentWorld = new World();
            CurrentPlayer = new Player();

            World.Regions region;
            foreach(string regString in Enum.GetNames(typeof(World.Regions)))
            {
                
                Enum.TryParse(regString, out region);
                CurrentWorld.AddRegion(region, RegionFactory.CreateRegion(region));
            }
            CurrentRegion = CurrentWorld.GetRegion(World.Regions.HollowMouth);
            CurrentLocation = CurrentRegion.LocationAt(0, 0);
            
        }

        public void MoveNorth()
        {
            if (HasLocationToNorth)
            {
                CurrentLocation = CurrentRegion.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate+1);
            }
        }

        public void MoveSouth()
        {
            if (HasLocationToSouth)
            {
                CurrentLocation = CurrentRegion.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate-1);
            }
        }

        public void MoveEast()
        {
            if (HasLocationToEast)
            {
                CurrentLocation = CurrentRegion.LocationAt(CurrentLocation.XCoordinate+1, CurrentLocation.YCoordinate);
            }
        }

        public void MoveWest()
        {
            if (HasLocationToWest)
            {
                CurrentLocation = CurrentRegion.LocationAt(CurrentLocation.XCoordinate-1, CurrentLocation.YCoordinate);
            }
        }

        public void EnterDoor()
        {

            CurrentRegion = CurrentWorld.GetRegion(CurrentLocation.Door.RegionCode);
            CurrentLocation = CurrentRegion.LocationAt(CurrentLocation.Door.X, CurrentLocation.Door.Y);
        }

    }
}
