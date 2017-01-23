using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TaalRekenenBasic;

namespace TaalRekenenBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            Program main = new Program();
            Option option = new Option();

            Console.WriteLine("Druk op Q om te stoppen.\n\nTyp je voornaam in:");
            
            if (main.ChooseName() == true)
            {
                option.ChooseOption();
            }
        }

        public bool ChooseName()
        {
            string input;
            bool continueFlag = false;
            Regex regex = new Regex("[^a-zA-Z0-9 ]");
            Program main = new Program();

            do
            {
                input = Console.ReadLine();

                switch (input)
                {
                    case "q":
                    case "Q":
                    case "quit":
                    case "Quit":
                        Environment.Exit(0);
                        break;
                }

                if (!string.IsNullOrEmpty(input) && !input.Any(char.IsDigit) && !regex.IsMatch(input))
                {
                    this.CurrentUser = input;
                    Console.WriteLine("\nWelkom {0}", CurrentUser);
                    continueFlag = true;
                }
                else
                {
                    Console.WriteLine("Sorry maar de ingevoerde voornaam is onjuist.\nProbeer het opnieuw");
                    continueFlag = false;
                }
            }
            while (continueFlag == false);

            return continueFlag;
        }

        public string CurrentUser { get; set; }
    }
}