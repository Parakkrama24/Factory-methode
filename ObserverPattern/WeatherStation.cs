using ObserverPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern 
{
    internal class WeatherStation : ISubject
    {
        private List<IWeatherObserver> observers = new List<IWeatherObserver>();
        private float temperature;
        private float humidity;
        public void AddObserver(IWeatherObserver observer)
        {
            observers.Add(observer);
        }

      

        public void RemoveObserver(IWeatherObserver observer)
        {
            observers.Remove(observer);
        }


        public void SetWeatherData(float temperature, float humidity)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            NotifyObservers();
        }
        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature, humidity);
            }
        }
    }
}
