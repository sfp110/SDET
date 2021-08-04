using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariPark
{
    public class Hunter : Person
    {
        private string _camera;

        public override string ToString()
        {
            return $"{base.ToString()} Camera: {_camera}";
        }

        //The constructor can't run if the base Person doesn't send in the required elements
        public Hunter(string firstName, string lastName = "", string camera = "") : base(firstName, lastName)
        {
            this._camera = camera;
        }

        public string Shoot()
        {
            return $"{GetFullName()} has taken a photo with their {_camera}";
        }
        
        public string CameraName()
        {
            return $"{_camera}";
        }

        public string Camera => _camera;
    }
}