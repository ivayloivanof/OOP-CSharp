namespace _01.GalacticGPS
{
    using System;

    struct Location
    {
        private double latitude;
        private double longitude;

        public Location(double latitude, double longtitude, Planet planet) 
            : this()
        {
            this.Latitude = latitude;
            this.Longitude = longtitude;
            this.Planet = planet;
        }

        public double Latitude
        {
            get
            {
                return this.latitude;
                
            }
            set
            {
                if (value < -90 || value > 90)
                {
                    throw new ArgumentOutOfRangeException("latitude", "Latitude should be in the range [-90...90].");
                }

                this.latitude = value;
            }
        }

        public double Longitude
        {
            get
            {
                return this.longitude;
                
            }
            set
            {
                if (value < -180 || value > 180)
                {
                    throw new ArgumentOutOfRangeException("longitude", "Longitude should be in the rage [-180...180]");
                }

                this.longitude = value;
            }
        }

        public Planet Planet { get; set; }

        public override string ToString()
        {
            string result = string.Format("{0}, {1} - {2}"
                , this.latitude, this.longitude, this.Planet);
            return result;
        }
    }
}