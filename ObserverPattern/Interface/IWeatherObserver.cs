

namespace ObserverPattern.Interface
{
    internal interface IWeatherObserver
    {
        void Update(float temperature, float humidity);
    }
}
