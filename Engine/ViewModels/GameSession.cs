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


            }
        }
        public Region CurrentRegion { get; set; }
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

        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentRegion = RegionFactory.CreateRegion("HollowMouth");
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

        public void BoardBoat()
        {

        }

    }
}
