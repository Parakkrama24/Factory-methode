
namespace ObserverPattern.Interface
{
    internal interface ISubject
    {
        void AddObserver(IWeatherObserver observer);
        void RemoveObserver(IWeatherObserver observer);
        void NotifyObservers();
    }
}
