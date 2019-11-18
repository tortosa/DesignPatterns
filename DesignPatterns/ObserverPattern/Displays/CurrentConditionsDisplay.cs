using ObserverPattern.ObserverPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Displays
{
    public class CurrentConditionsDisplay : BaseDisplay
    {
        public CurrentConditionsDisplay(Subject weatherData) : base(weatherData)
        {}

        public override void Display()
        {
            Console.WriteLine($"CurrentConditionsDisplay --- Temperature - {this.data.Temperature}, Pressure - {this.data.Pressure}, Humidity - {this.data.Humidity}");
        }
    }
}