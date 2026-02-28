class StringView
{
    private StringService service = new StringService();

    public void Run()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n==== STRING PROCESSING SYSTEM ====");
            Console.WriteLine("1. Enter Text");
            Console.WriteLine("2. View Current Text");
            Console.WriteLine("3. Convert to UPPERCASE");
            Console.WriteLine("4. Convert to lowercase");
            Console.WriteLine("5. Count Characters");
            Console.WriteLine("6. Check if Contains Word");
            Console.WriteLine("7. Replace Word");
            Console.WriteLine("8. Extract Substring");
            Console.WriteLine("9. Trim Spaces");
            Console.WriteLine("10. Reset Text");
            Console.WriteLine("11. Exit");
            Console.Write("Choose option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter text: ");
                    service.SetText(Console.ReadLine());
                    break;

                case "2":
                    Console.WriteLine("Current Text: " + service.GetText());
                    break;

                case "3":
                    service.ToUpperCase();
                    Console.WriteLine("Converted to UPPERCASE.");
                    break;

                case "4":
                    service.ToLowerCase();
                    Console.WriteLine("Converted to lowercase.");
                    break;

                case "5":
                    Console.WriteLine("Characters: " + service.CountCharacters());
                    break;

                case "6":
                    Console.Write("Enter word: ");
                    Console.WriteLine("Contains? " + service.ContainsWord(Console.ReadLine()));
                    break;

                case "7":
                    Console.Write("Old word: ");
                    string oldWord = Console.ReadLine();
                    Console.Write("New word: ");
                    string newWord = Console.ReadLine();
                    service.ReplaceWord(oldWord, newWord);
                    Console.WriteLine("Word replaced.");
                    break;

                case "8":
                    Console.Write("Start index: ");
                    int start = int.Parse(Console.ReadLine());
                    Console.Write("Length: ");
                    int length = int.Parse(Console.ReadLine());
                    service.ExtractSubstring(start, length);
                    break;

                case "9":
                    service.TrimSpaces();
                    Console.WriteLine("Spaces trimmed.");
                    break;

                case "10":
                    service.Reset();
                    Console.WriteLine("Text reset.");
                    break;

                case "11":
                    running = false;
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
