using ObserverPattern.ObserverPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Displays
{
    public class StatisticsDisplay : BaseDisplay
    {
        public StatisticsDisplay(Subject weatherData) : base(weatherData)
        { }

        public override void Display()
        {
            Console.WriteLine($"StatisticsDisplay --- Temperature - {this.data.Temperature}, Pressure - {this.data.Pressure}, Humidity - {this.data.Humidity}");
        }
    }
}