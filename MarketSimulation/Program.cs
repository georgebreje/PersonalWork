using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketSimulation
{

    class Program
    {

        public static void Main(string[] args)
        {
            Market.Advertisment();

        }
    }
    public class Dialogue
    {

        public static void EmployeeMessage()
        {
            Console.WriteLine("Welcome");
        }
    }
    public class Market
    {
        public static void Advertisment()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Support small businesses");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press ENTER to start shopping");
            Console.ResetColor();
        }
    }
    public class Employee
    {

    }
    public class Customer
    {
        Customer Decision = new Customer();
        public Customer()
        {
            Decision = Choice.EntryChoiceAction();
        }
    }
    public class Choice
    {
        Choice EntryChoice = new Choice();
        public Choice()
        {
            EntryChoice = EntryChoiceAction();
        }
        public static void EntryChoiceAction()
        {
            if (Console.ReadKey().Key == ConsoleKey.Enter)
                Dialogue.EmployeeMessage();
        }

    }
    public class Preferences
    { 

    }
}
