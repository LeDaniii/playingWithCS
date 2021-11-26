MainMenu();

static void MainMenu()
{
    while (true)
    {
        Console.WriteLine("##### HANGMAN #####");
        Console.WriteLine("###################");
        Console.WriteLine();

        Console.WriteLine("Wähle eine Aktion aus");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("[1] Spielen");
        Console.WriteLine("[2] Beenden");
        Console.ResetColor();
        Console.WriteLine();

        Console.Write("Aktion: ");
        int action = Convert.ToInt32(Console.ReadLine());
        bool end = false;

        switch (action)
        {
            case 1:
                StartGame();
                break;
            case 2:
                end = true;
                break;
        }

        if (end)
        {
            break;
        }

        Console.Clear();
    }
}

static void StartGame()
{
    string[] words = new string[]
    {
        "Apfelkuchen",
        "Gemüsesuppe",
        "Kraftfahrzeug",
        "LastWagen",
        "Videospiel",
        "Alarmanlage",
        "Vollkornbrot"
    };

    Random rnd = new Random();
    int index = rnd.Next(0, words.Length);
    string word = words[index].ToLower();
    GameLoop(word);
}

static void GameLoop(string word)
{
    int lives = 10;
    string hiddenWord = "";

    for(int i = 0; i < word.Length; i++)
    {
        hiddenWord += "_";
    }
    
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Gesuchtes Wort: " + hiddenWord);
        Console.Write("Noch übrige versuche: ");

        for (int i = 0; i < lives; i++)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("X");
            Console.ResetColor();
        }

        Console.WriteLine();
        Console.Write("Buchstabe: ");
        char character = Convert.ToChar(Console.ReadLine().ToLower());
    }
}