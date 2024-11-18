using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorypattern
{
    public interface IPizza
    {
        void Prepre();
    }


    public class cheezePizza : IPizza
    {
        public void Prepre()
        {
            Console.WriteLine("Prepering cheezaPizza");
        }
    }

    public class veigeePizza : IPizza
    {
        public void Prepre()
        {
            Console.WriteLine("Prepering vegiee Pizaa");
        }
    }

    public class PeporonPizza : IPizza
    {
        public void Prepre()
        {
            Console.WriteLine("Prepering Peporone Pizza");
        }
    }


    public static class PizzaFactory
    {
        public static IPizza CreatePizza(string PizzaType)
        {

            switch (PizzaType)
            {

                case "Cheeze":
                    return new cheezePizza();
                case "Veigee":
                    return new veigeePizza();
                case "Peporon":
                    return new PeporonPizza();
                default:
                    throw new ArgumentException("unkown Pizza");

            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pizza Factory!");
            Console.WriteLine("Available pizzas: Cheese, Pepperoni, Veggie");
            Console.Write("Please enter the type of pizza you want: ");

            string pizzaType = Console.ReadLine();

            try
            {
                IPizza pizza = PizzaFactory.CreatePizza(pizzaType);
                pizza.Prepre();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
