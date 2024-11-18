using System;

// Car interface - All cars can drive
public interface ICar
{
    void Drive();
}

// Engine interface - All engines can start
public interface IEngine
{
    void Start();
}

// USA Car
public class USACar : ICar
{
    public void Drive()
    {
        Console.WriteLine("Driving a USA car!");
    }
}

// USA Engine
public class USAEngine : IEngine
{
    public void Start()
    {
        Console.WriteLine("Starting a USA engine!");
    }
}

// European Car
public class EuropeCar : ICar
{
    public void Drive()
    {
        Console.WriteLine("Driving a European car!");
    }
}

// European Engine
public class EuropeEngine : IEngine
{
    public void Start()
    {
        Console.WriteLine("Starting a European engine!");
    }
}

// Factory to create cars and engines
public interface ICarFactory
{
    ICar CreateCar();
    IEngine CreateEngine();
}

// Factory for USA
public class USACarFactory : ICarFactory
{
    public ICar CreateCar() => new USACar();
    public IEngine CreateEngine() => new USAEngine();
}

// Factory for Europe
public class EuropeCarFactory : ICarFactory
{
    public ICar CreateCar() => new EuropeCar();
    public IEngine CreateEngine() => new EuropeEngine();
}

// Client code: Choose a factory based on your region
class Program
{
    static void Main()
    {
        Console.WriteLine("Pick a region: 1. USA 2. Europe");
        int choice = int.Parse(Console.ReadLine());

        ICarFactory carFactory;

        if (choice == 1)
        {
            carFactory = new USACarFactory();
        }
        else
        {
            carFactory = new EuropeCarFactory();
        }

        // Create a car and engine based on the selected factory
        ICar car = carFactory.CreateCar();
        IEngine engine = carFactory.CreateEngine();

        // Use the car and engine
        car.Drive();
        engine.Start();
    }

}
