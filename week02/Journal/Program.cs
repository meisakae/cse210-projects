using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        //Entry anEntry = new Entry();
        //anEntry.Display();
        string userChoice = "";

        while (userChoice != "5")
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices.");

            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would like to do?");

            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("> ");
                string response = Console.ReadLine();

                Entry entry = new Entry
                {
                    _date = DateTime.Now.ToShortDateString(),
                    _promptText = prompt,
                    _entryText = response
                };
                theJournal.AddEntry(entry);
            }
            else if (userChoice == "2")
            {
                theJournal.DispayAll();
            }
            else if (userChoice == "3")
            {
                Console.Write("What is the file name?: ");
                string filename = Console.ReadLine();
                theJournal.LoadFromFile(filename);
            }
            else if (userChoice == "4")
            {
                Console.Write("Enter the file name to save: ");
                string filename = Console.ReadLine();
                theJournal.SaveToFile(filename);
            }
            else if (userChoice == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

        }
    }
}