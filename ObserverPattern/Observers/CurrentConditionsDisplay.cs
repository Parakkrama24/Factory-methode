using ObserverPattern.Interface;
using System;

namespace ObserverPattern
{
    internal class CurrentConditionsDisplay : IWeatherObserver
    {
        public void Update(float temperature, float humidity)
        {
            Console.WriteLine($"Current Conditions: Temperature = {temperature}°C, Humidity = {humidity}%");
        }
    }
}
