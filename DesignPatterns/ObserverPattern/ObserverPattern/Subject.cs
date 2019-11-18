using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.ObserverPattern
{
    public interface Subject
    {
        void RegisterObserver(Observer observer);

        void RemoveObserver(Observer observer);

        void NotifyObservers();
    }
}