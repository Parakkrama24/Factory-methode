using System;

public abstract class DataProcessor
{
    // Template Method
    public void ProcessData()
    {
        LoadData();
        Process();
        SaveData();
    }

    // Common steps with default implementations
    protected virtual void LoadData()
    {
        Console.WriteLine("Loading data...");
    }

    protected virtual void SaveData()
    {
        Console.WriteLine("Saving processed data...");
    }

    // Abstract method to enforce custom processing logic
    protected abstract void Process();
}
