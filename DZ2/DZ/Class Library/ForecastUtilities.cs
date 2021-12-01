using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library
{
    public class ForecastUtilities
    {

        public static DailyForecast Parse(string line)
        {
            string[] lines = line.Split(",");
            DateTime time = DateTime.Parse(lines[0]);
            double temperature = double.Parse(lines[1]);
            double humidity = double.Parse(lines[2]);
            double windSpeed = double.Parse(lines[3]);
            return new DailyForecast(time, new Weather(temperature, humidity, windSpeed));
        }

        public static Weather FindWeatherWithLargestWindchill(Weather[] weathers)
        {
            Weather largestWindchill = new Weather();
            largestWindchill = weathers[0];
            for (int i = 0; i < weathers.Length; i++)
            {
                if (weathers[i].CalculateWindChill() > largestWindchill.CalculateWindChill())
                    largestWindchill = weathers[i];
            }

            return largestWindchill;
        }
    }
}
