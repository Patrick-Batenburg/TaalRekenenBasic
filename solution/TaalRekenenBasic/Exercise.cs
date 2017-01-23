using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaalRekenenBasic;

namespace TaalRekenenBasic
{
    public class Exercise
    {
        private string currentExercise;
        string filePath;
        FileInfo file;
        string answer;
        string tempString;
        string input;
        int sentenceCounter;
        int score;
        decimal result;
        bool continueFlag;
        string[] wrongMessages;
        string[] correctMessages;
        Random randomizer;

        public Exercise()
        {
            Option option = new Option();
            randomizer = new Random();
            continueFlag = false;
            sentenceCounter = 0;
            score = 0;
            result = 0;
            answer = "";
            tempString = "";
            input = "";
            wrongMessages = new string[] 
            {
                "Sorry, maar het antwoord was onjuist.",
                "Helaas, dat was niet het juiste antwoord.",
                "Het antwoord was fout.",
                "Sorry, maar het antwoord was niet correct.",
                "Helaas, het antwoord was fout."
            };
            correctMessages = new string[]
            {
                "Het antwoord was juist!",
                "Het antwoord was correct!",
                "Goedzo!",
                "het antwoord was inderdaad goed.",
                "Dat was het goede antwoord."
            };
        }

        public void GenerateExercise(int option)
        {
            continueFlag = false;

            switch (option)
            {
                case 1:
                    Console.WriteLine("\nJe hebt gekozen voor Rekenen - Aftrekken.\n");
                    filePath = AppDomain.CurrentDomain.BaseDirectory + @"\TaalRekenenBasic\Rekenen_-_Aftrekken.txt";
                    //filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\TaalRekenenBasic\Rekenen_-_Aftrekken.txt";
                    file = new FileInfo(filePath);
                    file.Directory.Create(); // If the directory already exists, this method does nothing.

                    if (!File.Exists(filePath))
                    {
                        // Create a file to write to.
                        using (StreamWriter streamWriter = File.CreateText(filePath))
                        {
                            streamWriter.WriteLine("67 - 45 =,22");
                            streamWriter.WriteLine("27 - 13 =,14");
                            streamWriter.WriteLine("73 - 41 =,32");
                            streamWriter.WriteLine("58 - 13 =,45");
                            streamWriter.WriteLine("96 - 51 =,45");
                            streamWriter.WriteLine("77 - 54 =,23");
                            streamWriter.WriteLine("78 - 26 =,52");
                            streamWriter.WriteLine("85 - 54 =,31");
                            streamWriter.WriteLine("14 - 13 =,1");
                            streamWriter.WriteLine("43 - 12 =,31");
                        }
                    }

                    // Open the file to read from.
                    DoExercise(file, filePath);
                    break;
                case 2:
                    Console.WriteLine("\nJe hebt gekozen voor Rekenen - Optellen.\n");
                    filePath = AppDomain.CurrentDomain.BaseDirectory + @"\TaalRekenenBasic\Rekenen_-_Optellen.txt";
                    //filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\TaalRekenenBasic\Rekenen_-_Optellen.txt";
                    file = new FileInfo(filePath);
                    file.Directory.Create(); // If the directory already exists, this method does nothing.

                    if (!File.Exists(filePath))
                    {
                        // Create a file to write to.
                        using (StreamWriter streamWriter = File.CreateText(filePath))
                        {
                            streamWriter.WriteLine("5 + 3 =,8");
                            streamWriter.WriteLine("10 + 4 =,14");
                            streamWriter.WriteLine("9 + 25 =,24");
                            streamWriter.WriteLine("3 + 3 =,6");
                            streamWriter.WriteLine("2 + 15 =,17");
                            streamWriter.WriteLine("22 + 3 =,25");
                            streamWriter.WriteLine("52 + 3 =,55");
                            streamWriter.WriteLine("9 + 30 =,39");
                            streamWriter.WriteLine("42 + 11 =,53");
                            streamWriter.WriteLine("10 + 36 =,46");
                        }
                    }

                    // Open the file to read from.
                    DoExercise(file, filePath);
                    break;
                case 3:
                    Console.WriteLine("\nJe hebt gekozen voor Rekenen - Delen.\n");
                    filePath = AppDomain.CurrentDomain.BaseDirectory + @"\TaalRekenenBasic\Rekenen_-_Delen.txt";
                    //filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\TaalRekenenBasic\Rekenen_-_Delen.txt";
                    file = new FileInfo(filePath);
                    file.Directory.Create(); // If the directory already exists, this method does nothing.

                    if (!File.Exists(filePath))
                    {
                        // Create a file to write to.
                        using (StreamWriter streamWriter = File.CreateText(filePath))
                        {
                            streamWriter.WriteLine("75 : 5 =,15");
                            streamWriter.WriteLine("42 : 7 =,6");
                            streamWriter.WriteLine("30 : 2 =,15");
                            streamWriter.WriteLine("35 : 5 =,7");
                            streamWriter.WriteLine("10 : 2 =,5");
                            streamWriter.WriteLine("56 : 7 =,8");
                            streamWriter.WriteLine("12 : 6 =,2");
                            streamWriter.WriteLine("63 : 7 =,9");
                            streamWriter.WriteLine("90 : 6 =,15");
                        }
                    }

                    // Open the file to read from.
                    DoExercise(file, filePath);
                    break;
                case 4:
                    Console.WriteLine("\nJe hebt gekozen voor Rekenen - Vermenigvuldigen.\n");
                    filePath = AppDomain.CurrentDomain.BaseDirectory + @"\TaalRekenenBasic\Rekenen_-_Vermenigvuldigen.txt";
                    //filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\TaalRekenenBasic\Rekenen_-_Vermenigvuldigen.txt";
                    file = new FileInfo(filePath);
                    file.Directory.Create(); // If the directory already exists, this method does nothing.

                    if (!File.Exists(filePath))
                    {
                        // Create a file to write to.
                        using (StreamWriter streamWriter = File.CreateText(filePath))
                        {
                            streamWriter.WriteLine("8 x 5 =,40");
                            streamWriter.WriteLine("2 x 7 =,14");
                            streamWriter.WriteLine("6 x 9 =,54");
                            streamWriter.WriteLine("4 x 6 =,24");
                            streamWriter.WriteLine("3 x 9 =,27");
                            streamWriter.WriteLine("3 x 7 =,21");
                            streamWriter.WriteLine("2 x 4 =,8");
                            streamWriter.WriteLine("7 x 4 =,28");
                            streamWriter.WriteLine("8 x 7 =,56");
                            streamWriter.WriteLine("2 x 6 =,12");
                            streamWriter.WriteLine("5 x 4 =,20");
                            streamWriter.WriteLine("4 x 9 =,36");
                            streamWriter.WriteLine("6 x 7 =,42");
                            streamWriter.WriteLine("5 x 6 =,30");
                        }
                    }

                    // Open the file to read from.
                    DoExercise(file, filePath);
                    break;
                case 5:
                    Console.WriteLine("\nJe hebt gekozen voor Rekenen - Alles door elkaar.\n");
                    filePath = AppDomain.CurrentDomain.BaseDirectory + @"\TaalRekenenBasic\Rekenen_-_Alles_Door_Elkaar.txt";
                    //filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\TaalRekenenBasic\Rekenen_-_Alles_Door_Elkaar.txt";
                    file = new FileInfo(filePath);
                    file.Directory.Create(); // If the directory already exists, this method does nothing.

                    if (!File.Exists(filePath))
                    {
                        // Create a file to write to.
                        using (StreamWriter streamWriter = File.CreateText(filePath))
                        {
                            streamWriter.WriteLine("37 - 19 =,16");
                            streamWriter.WriteLine("41 + 14 =,55");
                            streamWriter.WriteLine("43 + 28 =,71");
                            streamWriter.WriteLine("3 x 9 =,27");
                            streamWriter.WriteLine("52 : 4 =,13");
                            streamWriter.WriteLine("5 x 6 =,30");
                            streamWriter.WriteLine("25 - 13 =,12");
                            streamWriter.WriteLine("41 + 14 =,55");
                            streamWriter.WriteLine("9 x 8 =,81");
                            streamWriter.WriteLine("43 + 28 =,71");
                            streamWriter.WriteLine("72 : 9 =,8");
                            streamWriter.WriteLine("3 x 8 =,24");
                            streamWriter.WriteLine("73 - 8 =,65");
                            streamWriter.WriteLine("72 + 15 =,87");
                            streamWriter.WriteLine("49 : 7 =,7");
                        }
                    }
                    // Open the file to read from.
                    DoExercise(file, filePath);
                    break;
                case 6:
                    Console.WriteLine("\nJe hebt gekozen voor Taal - Tegenwoordige Tijd.\n");
                    filePath = AppDomain.CurrentDomain.BaseDirectory + @"\TaalRekenenBasic\Taal_-_Tegenwoordige_Tijd.txt";
                    //filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\TaalRekenenBasic\Taal_-_Tegenwoordige_Tijd.txt";
                    file = new FileInfo(filePath);
                    file.Directory.Create(); // If the directory already exists, this method does nothing.

                    if (!File.Exists(filePath))
                    {
                        // Create a file to write to.
                        using (StreamWriter streamWriter = File.CreateText(filePath))
                        {
                            streamWriter.WriteLine("De man ... met zijn kar door de straat. (lopen),loopt");
                            streamWriter.WriteLine("Hij ... naar de markt. (gaan),gaat");
                            streamWriter.WriteLine("Onderweg ... hij een meisje tegen. (komen),komt");
                            streamWriter.WriteLine("Dat meisje ... hem wel aardig. (vinden),vindt");
                            streamWriter.WriteLine("Zij ... hem dan ook hartelijk. (groeten),groet");
                            streamWriter.WriteLine("Daarna ... zij hem waar hij naar toe gaat. (vragen),vraagt");
                            streamWriter.WriteLine("Ik ... naar de markt. (willen),wilt");
                            streamWriter.WriteLine("Wat ... daar allemaal verkocht? (worden),wordt");
                            streamWriter.WriteLine("\"Ik ga groenten en fruit kopen,\" ... de man.  (vertellen),vertelt");
                            streamWriter.WriteLine("\"Heb je daarom je kar bij je?\" ... het meisje. (zeggen),zegt");
                            streamWriter.WriteLine("De man ... hierop dat dat inderdaad daarom is. (antwoorden),antwoordt");
                        }
                    }

                    // Open the file to read from.
                    DoExercise(file, filePath);
                    break;
                case 7:
                    Console.WriteLine("\nJe hebt gekozen voor Taal - Verleden Tijd.\n");
                    filePath = AppDomain.CurrentDomain.BaseDirectory + @"\TaalRekenenBasic\Taal_-_Verleden_Tijd.txt";
                    //filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\TaalRekenenBasic\Taal_-_Verleden_Tijd.txt";
                    file = new FileInfo(filePath);
                    file.Directory.Create(); // If the directory already exists, this method does nothing.

                    if (!File.Exists(filePath))
                    {
                        // Create a file to write to.
                        using (StreamWriter streamWriter = File.CreateText(filePath))
                        {
                            streamWriter.WriteLine("Hij ... na lang zoeken de schat. (Vinden),vond");
                            streamWriter.WriteLine("De gelukkige ... ze lang vast. (Houden),hield");
                            streamWriter.WriteLine("Die auto ... veel te hard door het centrum. (Rijden),reed");
                            streamWriter.WriteLine("...ze wel lang genoeg na? (Denken),Dacht");
                            streamWriter.WriteLine("Ook slimme leerlingen ... soms verkeerd. (Antwoorden),antwoordden");
                            streamWriter.WriteLine("Hoeveel ... ze voor dat kunstwerk? (Bieden),boden");
                            streamWriter.WriteLine("Tijdens de vakantie ... zus een leuk kaartje. (Zenden),zond");
                            streamWriter.WriteLine("We ... niet dat ze zo snel zou terug zijn! (Vermoeden),vermoedden");
                            streamWriter.WriteLine("... jij ook daar? (Zijn),Was");
                            streamWriter.WriteLine("Sommige kinderen ... nooit goed op. (Opletten),letten");
                        }
                    }

                    // Open the file to read from.
                    DoExercise(file, filePath);
                    break;
                case 8:
                    Console.WriteLine("\nJe hebt gekozen voor Taal - Voltooid Deelwoord.\n");
                    filePath = AppDomain.CurrentDomain.BaseDirectory + @"\TaalRekenenBasic\Taal_-_Voltooid_Deelwoord.txt";
                    //filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\TaalRekenenBasic\Taal_-_Voltooid_Deelwoord.txt";
                    file = new FileInfo(filePath);
                    file.Directory.Create(); // If the directory already exists, this method does nothing.

                    if (!File.Exists(filePath))
                    {
                        // Create a file to write to.
                        using (StreamWriter streamWriter = File.CreateText(filePath))
                        {
                            streamWriter.WriteLine("Ik ben gisteren niet thuis ... . (blijven),gebleven");
                            streamWriter.WriteLine("Mijn vrienden hebben me om half negen ... . (ophalen),opgehaald");
                            streamWriter.WriteLine("Ze waren helemaal naar Eindhoven ... . (fietsen),gefietst");
                            streamWriter.WriteLine("We zijn daarna naar de disco ... . (gaan),gegaan");
                            streamWriter.WriteLine("Ik heb gisteren in de disco ... . (dansen),gedanst");
                            streamWriter.WriteLine("Ik heb mijn spullen ... . (verhuizen),verhuisd");
                            streamWriter.WriteLine("Vorige week had ik de kaartjes al ... . (kopen),gekocht");
                            streamWriter.WriteLine("De kaartjes voor deze disco zijn namelijk snel ... . (uitverkopen),uitverkocht");
                            streamWriter.WriteLine("Voor de kaartjes heb ik een maand ... .(sparen),gespaard");
                            streamWriter.WriteLine("Het was veel werk, maar ik had er ook hard voor ... . (werken),gewerkt");
                        }
                    }

                    // Open the file to read from.
                    DoExercise(file, filePath);
                    break;
            }
        }

        public bool DoExercise(string filePath)
        {
            continueFlag = false;
            Option option = new Option();

            using (StreamReader streamReader = File.OpenText(filePath))
            {
                Console.WriteLine("\nJe hebt gekozen voor " + System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(filePath.Substring(filePath.LastIndexOf(@"\") + 1).Replace("_", " ").Replace(".txt", "")) + "\n");

                while ((tempString = streamReader.ReadLine()) != null)
                {
                    sentenceCounter++;
                    Console.WriteLine(tempString.Substring(0, tempString.LastIndexOf(",")));
                    answer = tempString.Substring(tempString.LastIndexOf(",") + 1).ToLower();
                    input = Console.ReadLine();

                    if (input.ToLower() == answer.ToLower())
                    {
                        score++;
                        Console.WriteLine("{0}\n", correctMessages[randomizer.Next(0, 5)]);
                    }
                    else
                    {
                        Console.WriteLine("{0}\nHet goede antwoord was: {1}\n", wrongMessages[randomizer.Next(0, 5)], answer);
                    }
                }

                if (sentenceCounter > 0)
                {
                    result = Math.Round(((10 / (decimal)sentenceCounter) * (decimal)score), 1);
                }

                Console.WriteLine("Je hebt van de {0} vragen er {1} goed. Dat is een {2}\n", sentenceCounter, score, result);
                Console.WriteLine("Druk op Q om te stoppen of druk op E om een nieuwe oefenening te selecteren");

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
                            sentenceCounter = 0;
                            score = 0;
                            result = 0;
                            answer = "";
                            tempString = "";
                            input = "";
                            break;
                        case "e":
                        case "E":
                            continueFlag = true;
                            sentenceCounter = 0;
                            score = 0;
                            result = 0;
                            answer = "";
                            tempString = "";
                            input = "";
                            option.ChooseOption();
                            break;
                        default:
                            Console.WriteLine("Ongeldige optie, probeer het opnieuw.");
                            continueFlag = false;
                            sentenceCounter = 0;
                            score = 0;
                            result = 0;
                            answer = "";
                            tempString = "";
                            input = "";
                            break;
                    }
                }
                while (continueFlag == false);
            }

            return continueFlag;
        }

        public void DoExercise(FileInfo file, string filePath)
        {
            continueFlag = false;
            Option option = new Option();

            using (StreamReader streamReader = File.OpenText(filePath))
            {
                while ((tempString = streamReader.ReadLine()) != null)
                {
                    sentenceCounter++;
                    Console.WriteLine(tempString.Substring(0, tempString.LastIndexOf(",")));
                    answer = tempString.Substring(tempString.LastIndexOf(",") + 1).ToLower();
                    input = Console.ReadLine();

                    if (input.ToLower() == answer.ToLower())
                    {
                        score++;
                        Console.WriteLine("{0}\n", correctMessages[randomizer.Next(0, 5)]);
                    }
                    else
                    {
                        Console.WriteLine("{0}\nHet goede antwoord was: {1}\n", wrongMessages[randomizer.Next(0, 5)], answer);
                    }
                }

                if (sentenceCounter > 0)
                {
                    result = Math.Round(((10 / (decimal)sentenceCounter) * (decimal)score), 1);
                }

                Console.WriteLine("Je hebt van de {0} vragen er {1} goed. Dat is een {2}\n", sentenceCounter, score, result);
                Console.WriteLine("Druk op Q om te stoppen of druk op E om een nieuwe oefenening te selecteren");

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
                            sentenceCounter = 0;
                            score = 0;
                            result = 0;
                            answer = "";
                            tempString = "";
                            input = "";
                            break;
                        case "e":
                        case "E":
                            continueFlag = true;
                            option.ChooseOption();
                            sentenceCounter = 0;
                            score = 0;
                            result = 0;
                            answer = "";
                            tempString = "";
                            input = "";
                            break;
                        default:
                            Console.WriteLine("Ongeldige optie, probeer het opnieuw.");
                            continueFlag = false;
                            sentenceCounter = 0;
                            score = 0;
                            result = 0;
                            answer = "";
                            tempString = "";
                            input = "";
                            break;
                    }
                }
                while (continueFlag == false);
            }
        }

        public string CurrentExercise
        {
            get
            {
                return currentExercise;
            }
            set
            {
                currentExercise = value;
            }
        }
    }
}
