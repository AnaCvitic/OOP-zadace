using System;

namespace Class_Library
{
     public class Weather
    {
        private double temperature;
        private double humidity;
        private double windSpeed;
        public double GetTemperature() { return temperature; }
        public double GetHumidity() { return humidity; }
        public double GetWindSpeed() { return windSpeed; }
        public void SetTemperature(double temperature) { this.temperature = temperature; }
        public void SetHumidity(double humidity) { this.humidity = humidity; }
        public void SetWindSpeed(double windSpeed) { this.windSpeed = windSpeed; }
        public Weather()
        {
            temperature = 0;
            humidity = 0;
            windSpeed = 0;
        }
        public Weather(double temperature, double humidity, double windSpeed)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.windSpeed = windSpeed;
        }
        public double CalculateFeelsLikeTemperature()
        {
            double temperature = this.temperature * ((float)9 / 5) + 32;
            return ((-42.379 + 2.04901523 * temperature + 10.14333127 * humidity - 0.22475541 * temperature * humidity
                - 6.83783 * (Math.Pow(10, -3)) * (Math.Pow(temperature, 2)) - 5.481717 * (Math.Pow(10, -2)) * (Math.Pow(humidity, 2))
                + 1.22874 * (Math.Pow(10, -3)) * humidity * (Math.Pow(temperature, 2)) + 8.5282 * (Math.Pow(10, -4)) * temperature * (Math.Pow(humidity, 2))
                - 1.99 * (Math.Pow(10, -6)) * (Math.Pow(temperature, 2)) * (Math.Pow(humidity, 2))) - 32) * (float)5 / 9;
        }
        public double CalculateWindChill()
        {
            double windChill = (13.12 + 0.6215 * temperature - 11.37 * (Math.Pow(windSpeed, 0.16)) + 0.3965 * temperature * (Math.Pow(windSpeed, 0.16)));
            if (temperature>10 && windSpeed<=4.8)
            {
                windChill = 0;
            }
            return windChill;
        }
        public string GetAsString()
        {
            return $"T={temperature}°C, h={humidity}%, w={windSpeed}km/h";
        }
    }
}
 
