using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class WeatherInfo
    {
        public class Coord
        {

            public double lon { get; set; }
            public double lat { get; set; }
          
        }

        public class Weather
        {
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }

        }
        public class Main
        {
            public double temp { get; set; }
            public double pressure { get; set; }
            public double humidity { get; set; }
        }

        public class Wind 
        {
            public double speed { get; set; }
        }

        public class Sys
        {
            public long sunset { get; set; }
            public long sunrise { get; set; }
        }

        public class Root
        {
            public Coord Coord { get; set; }
            public List <Weather> Weather { get; set; }
            public Wind Wind { get; set; }
            public Sys Sys { get; set; }
            public Main Main { get; set; }
        }


    }
}
