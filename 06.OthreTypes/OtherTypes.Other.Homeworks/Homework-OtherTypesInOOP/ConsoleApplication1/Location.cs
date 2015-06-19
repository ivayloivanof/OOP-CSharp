using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public struct Location
    {
        private double latitude;
        private double longitude;

        public Location(double latitude,double longitude,Planet planet):this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Planet = planet;
        }
        public double Latitude
        {
            get { return this.latitude; }
            set
            {
                if(value<-90|| value>90)
                {
                    throw new ArgumentOutOfRangeException("Value must be floating between -90 to 90");
                }
                this.latitude = value;
            }
        }
       public double Longitude
        {
            get { return this.longitude; }
             set
             {
                 if(value<-180 || value>180)
                 {
                     throw new ArgumentOutOfRangeException("Value must be floating between -180 to 180");
                 }
                 this.longitude = value;
             }
        }
       public Planet Planet { get; set; }

       public override string ToString()
       {
           return string.Format("{0}{1}-{2}",this.Latitude,this.Longitude,this.Planet);
       }
    }
}
