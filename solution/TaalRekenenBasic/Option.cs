using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaalRekenenBasic
{
    public class Option
    {
        private int currentOption;
        private int totalOptions;
        string filePath;
        string input;
        int number;
        bool isNumeric;
        bool continueFlag;
        List<string> options;
        string folderPath;
        int optionCounter;

        public Option()
        {
            options = new List<string>();
            isNumeric = false;
            continueFlag = false;
            OptionCounter = 0;
        }

        public void ChooseOption()
        {
            Console.WriteLine("\nKies een optie om te leren oefenen of druk op A om standard opties te maken:");
            options = LoadOptions();
            continueFlag = false;
            Exercise exercise = new Exercise();

            do
            {
                continueFlag = false;
                if (options.Count == 0)
                {
                    Console.WriteLine("Er zijn geen opties beschikbaar, maak nieuwe vragen aan of druk op A voor de standaard opties.");
                }

                input = Console.ReadLine();
                isNumeric = Int32.TryParse(input, out number);

                switch (input)
                {
                    case "q":
                    case "Q":
                    case "quit":
                    case "Quit":
                        continueFlag = true;
                        Environment.Exit(0);
                        break;
                    case "a":
                    case "A":
                        Console.WriteLine("\nOptie 1 = Rekenen - Aftrekken\nOptie 2 = Rekenen - Optellen\nOptie 3 = Rekenen - Delen\nOptie 4 = Rekenen - Vermenigvuldigen\nOptie 5 = Rekenen - Alles Door Elkaar");
                        Console.WriteLine("Optie 6 = Taal - Tegenwoordige Tijd\nOptie 7 = Taal - Verleden Tijd\nOptie 8 = Taal - Voltooid Deelwoord");
                        do
                        {
                            input = Console.ReadLine();
                            Int32.TryParse(input, out number);
                            if (number < 9 && number > 0 && !String.IsNullOrWhiteSpace(input))
                            {
                                continueFlag = true;
                                exercise.GenerateExercise(number);
                            }
                            else
                            {
                                continueFlag = false;
                                Console.WriteLine("Ongeldige optie, probeer het opnieuw.");
                            }
                        }
                        while (continueFlag == false);
                        break;
                }

                if (TotalOptions > 0)
                {
                    if (isNumeric == true && Convert.ToInt32(input) < TotalOptions + 1 && Convert.ToInt32(input) > 0)
                    {
                        continueFlag = true;
                        CurrentOption = number;
                        filePath = options[CurrentOption - 1];
                        exercise.DoExercise(filePath);
                    }
                    else
                    {
                        continueFlag = false;
                        Console.WriteLine("Ongeldige optie, probeer het opnieuw.");
                    }
                }

                isNumeric = false;
            }
            while (continueFlag == false);
        }

        public List<string> LoadOptions()
        {
            continueFlag = false;
            folderPath = AppDomain.CurrentDomain.BaseDirectory + @"\TaalRekenenBasic\";
            //folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\TaalRekenenBasic\";
            DirectoryInfo di = Directory.CreateDirectory(folderPath); // If the directory already exists, this method does nothing.

            foreach (string file in Directory.EnumerateFiles(folderPath, "*.txt"))
            {
                string contents = File.ReadAllText(file);
                OptionCounter++;
                options.Add(file);
                options.Sort();
            }

            for (int i = 0; i < OptionCounter; i++)
            {
                string option = "Optie " + (i + 1) + " = " + options[i].Substring(options[i].LastIndexOf(@"\") + 1).Replace("_", " ").Replace(".txt", "");
                Console.WriteLine(System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(option));
            }

            TotalOptions = OptionCounter;
            OptionCounter = 0;
            return options;
        }

        public int CurrentOption
        {
            get
            {
                return currentOption;
            }
            set
            {
                currentOption = value;
            }
        }

        public int TotalOptions
        {
            get
            {
                return totalOptions;
            }
            set
            {
                totalOptions = value;
            }
        }

        public int OptionCounter
        {
            get
            {
                return optionCounter;
            }

            set
            {
                optionCounter = value;
            }
        }
    }
}
