using ObserverPattern.ObserverPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Displays
{
    public class ForecastDisplay : BaseDisplay
    {
        public ForecastDisplay(Subject weatherData) : base(weatherData)
        { }

        public override void Display()
        {
            Console.WriteLine($"ForecastDisplay --- Temperature - {this.data.Temperature}, Pressure - {this.data.Pressure}, Humidity - {this.data.Humidity}");
        }
    }
}