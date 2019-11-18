using ObserverPattern.ObserverPattern;
using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    public class WeatherData : Subject
    {
        private List<Observer> observers;
        private WeatherDto data;

        public WeatherData()
        {
            observers = new List<Observer>();
        }

        public void NotifyObservers()
        {
            foreach(Observer observer in observers)
            {
                observer.Update(data);
            }
        }

        public void RegisterObserver(Observer observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);
        }

        public void RemoveObserver(Observer observer)
        {
            observers.Remove(observer);
        }

        public void SetMeasurements(WeatherDto data)
        {
            this.data = data;
            MeasurementsChanged();
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }
    }
}