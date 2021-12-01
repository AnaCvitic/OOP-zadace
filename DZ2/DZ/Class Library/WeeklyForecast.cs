using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library
{
    public class WeeklyForecast
    {
        readonly DailyForecast[] dailyForecasts;
        

        public WeeklyForecast(DailyForecast[] dailyForecasts)
        {
            this.dailyForecasts = dailyForecasts;
        }
        public static bool operator <(WeeklyForecast forecast1, WeeklyForecast forecast2)
        {
            if( forecast1.GetMaxTemperature() > forecast2.GetMaxTemperature())
            return false;
            else  return true;
        }
        public static bool operator >(WeeklyForecast forecast1,WeeklyForecast forecast2)
        {
            if (forecast1.GetMaxTemperature() > forecast2.GetMaxTemperature())
                return true;
            else return false;
        }
        public double GetMaxTemperature()
        {
            DailyForecast max = dailyForecasts[0];
          for(int i =0; i<dailyForecasts.Length;i++)
            {
                if (dailyForecasts[i].Weather.GetTemperature() > max.Weather.GetTemperature())
                {
                    max = dailyForecasts[i];
                }
            }
            return max.Weather.GetTemperature();
        }
        
        public DailyForecast this[int dailyForecastIndex]
        {
            get {return dailyForecasts[dailyForecastIndex]; }
            set { dailyForecasts[dailyForecastIndex] = value; }
        }
        public string GetAsString()
        {
            return $" {dailyForecasts}";
        }


    }
}
