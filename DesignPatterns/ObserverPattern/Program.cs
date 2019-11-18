using ObserverPattern.Displays;
using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
           
            BaseDisplay currentConditionsDisplay = new HeatDisplay(weatherData);

            weatherData.SetMeasurements(new WeatherDto()
            {
                Humidity = 13.2f,
                Pressure = 1031f,
                Temperature = 31.2f
            });

            weatherData.SetMeasurements(new WeatherDto()
            {
                Humidity = 24.3f,
                Pressure = 1080f,
                Temperature = 42.2f
            });
        }
    }
}