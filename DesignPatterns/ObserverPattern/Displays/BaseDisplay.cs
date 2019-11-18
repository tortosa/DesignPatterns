using ObserverPattern.ObserverPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Displays
{
    public abstract class BaseDisplay : Observer, DisplayElement
    {
        protected WeatherDto data;
        protected Subject weatherData;

        public BaseDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.RegisterObserver(this);
        }

        public abstract void Display();

        public void Update(WeatherDto data)
        {
            this.data = data;
            this.Display();
        }
    }
}