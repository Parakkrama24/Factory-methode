using ObserverPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class StatisticsDisplay : IWeatherObserver
    {
        private float maxTemperature = float.MinValue;
        private float minTemperature = float.MaxValue;
        private float totalTemperature = 0;
        private int readingsCount = 0;

        public void Update(float temperature, float humidity)
        {
            maxTemperature = Math.Max(maxTemperature, temperature);
            minTemperature = Math.Min(minTemperature, temperature);
            totalTemperature += temperature;
            readingsCount++;

            Console.WriteLine($"Statistics: Max = {maxTemperature}°C, Min = {minTemperature}°C, Avg = {totalTemperature / readingsCount:0.0}°C");
        }
    }
}
