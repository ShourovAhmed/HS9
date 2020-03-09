using System;
using System.Collections.Generic;
using System.Text;

namespace Meetlat
{
    class Lat
    {
        public double BeginLengte { private get; set; }
        public double LengteInM
        {
            get { return BeginLengte; }
        }
        public double LengteInCm
        {
            get { return (BeginLengte * 100.0); }
        }
        public double LengteInKm {
            get { return (BeginLengte / 1000.0); }
        }
        public double LengteInVoet { 
            get { return (BeginLengte * 3.2808); }
        }
    }
}
