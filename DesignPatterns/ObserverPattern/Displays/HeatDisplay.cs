using ObserverPattern.ObserverPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Displays
{
    public class HeatDisplay : BaseDisplay
    {
        public HeatDisplay(Subject weatherData) : base(weatherData)
        { }

        public override void Display()
        {
            var heatIndex = ((16.923 + (0.185212 * this.data.Temperature) + (5.37941 * this.data.Humidity) - (0.100254 * this.data.Temperature * this.data.Humidity) +
                (0.00941695 * (this.data.Temperature * this.data.Temperature)) + (0.00728898 * (this.data.Humidity * this.data.Humidity)) +
                (0.000345372 * (this.data.Temperature * this.data.Temperature * this.data.Humidity)) - (0.000814971 * (this.data.Temperature * this.data.Humidity * this.data.Humidity)) +
                (0.0000102102 * (this.data.Temperature * this.data.Temperature * this.data.Humidity * this.data.Humidity)) - (0.000038646 * (this.data.Temperature * this.data.Temperature * this.data.Temperature)) + (0.0000291583 *
                (this.data.Humidity * this.data.Humidity * this.data.Humidity)) + (0.00000142721 * (this.data.Temperature * this.data.Temperature * this.data.Temperature * this.data.Humidity)) +
                (0.000000197483 * (this.data.Temperature * this.data.Humidity * this.data.Humidity * this.data.Humidity)) - (0.0000000218429 * (this.data.Temperature * this.data.Temperature * this.data.Temperature * this.data.Humidity * this.data.Humidity)) +
                0.000000000843296 * (this.data.Temperature * this.data.Temperature * this.data.Humidity * this.data.Humidity * this.data.Humidity)) -
                (0.0000000000481975 * (this.data.Temperature * this.data.Temperature * this.data.Temperature * this.data.Humidity * this.data.Humidity * this.data.Humidity)));

            Console.WriteLine($"HeatDisplay --- Temperature - {this.data.Temperature}, Pressure - {this.data.Pressure}, Humidity - {this.data.Humidity}, Heat Index - {heatIndex}");
        }
    }
}