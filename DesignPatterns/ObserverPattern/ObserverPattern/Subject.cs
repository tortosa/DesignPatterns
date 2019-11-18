using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.ObserverPattern
{
    public interface Subject
    {
        void RegisterObserver();

        void RemoveObserver();

        void NotifyObservers();
    }
}