using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand2
{
    static class UserInterface
    {
        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static string GetStringInput(string message)
        {
            Console.WriteLine(message);
            string input;
            input = Console.ReadLine();
            return input;
        }
        public static void DisplayRules()
        {

        }
        public static void DisplayBalance()
        {

        }

        public static void DisplayEndOfDay()
        {

        }

        public static void DisplayEndOfGame()
        {

        }

    }
}
