using System;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create WeatherStation (Subject)
            var weatherStation = new WeatherStation();

            // Create Observers
            var currentConditionsDisplay = new CurrentConditionsDisplay();
            var statisticsDisplay = new StatisticsDisplay();

            // Subscribe Observers
            weatherStation.AddObserver(currentConditionsDisplay);
            weatherStation.AddObserver(statisticsDisplay);

            // Simulate Weather Data Updates
            weatherStation.SetWeatherData(25.0f, 65.0f);
            weatherStation.SetWeatherData(30.0f, 70.0f);
            weatherStation.SetWeatherData(20.0f, 90.0f);

            // Unsubscribe an Observer
            weatherStation.RemoveObserver(currentConditionsDisplay);

            // Simulate another Weather Data Update
            weatherStation.SetWeatherData(28.0f, 75.0f);

            Console.ReadKey();
        }
    }
    
}
