using System;

namespace GalacticGPS.Class
{
    public struct Location
    {
        private double latitude;
        private double longitude;
        private Enum planet;

        public Location(double latitude, double longitude, Enum planet) : this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Planet = planet;
        }

        public double Longitude
        {
            get { return this.longitude; }
            set
            {
                if (value < -180.0 && value > 180.0)
                    throw new ArgumentOutOfRangeException("longitude", "This value for Longitude not is correct (from -180 to 180)");
                this.longitude = value;
            }
        }
        public double Latitude
        {
            get { return this.latitude; }
            set
            {
                if (value < -90 && value > 90)
                    throw new ArgumentOutOfRangeException("latitude", "This value for Latitude not is correct (from -90 to 90)");
                this.latitude = value;
            }
        }
        public Enum Planet
        {
            get { return this.planet; }
            set { this.planet = (Planet) Enum.Parse(typeof (Planet), value.ToString()); }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1} - {2}", this.Latitude, this.Longitude, this.Planet);
        }
    }
}
