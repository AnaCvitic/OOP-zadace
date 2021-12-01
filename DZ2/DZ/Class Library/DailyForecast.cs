using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library
{
    public class DailyForecast
    {
       public DateTime Time { get; private set; }
      public  Weather Weather { get; private set; }
        public DailyForecast(DateTime time, Weather weather)
        {
            Time = time;
            Weather = weather;
        }
        public string GetAsString()
        {
            return $"{Time}, {Weather}";
        }

    }
    
}
