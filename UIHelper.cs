    using System;
    using System.Media;
    using System.Threading;

    namespace CyberSecurityBot
    {
    public static class UIHelper
    {
    public static void DisplayAsciiArt()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine(@"
    _____       _               _____            _   
    / ____|     | |             |  __ \          | |  
    | |    _   _ | |__   ___ _ __| |__) |___  __ _| |_ 
    | |   | | | || '_ \ / _ \ '__|  _  // _ \/ _` | __|
    | |___| |_| || |_) |  __/ |  | | \ \  __/ (_| | |_ 
    \_____\__, ||_.__/ \___|_|  |_|  \_\___|\__,_|\__|
        __/ |                                      
    |___/                                       
    ");

        Console.ResetColor();
    }

    public static void PrintDivider()
    {
        Console.WriteLine("============================================");
    }

    public static void TypingEffect(string message)
    {
        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(20);
        }
        Console.WriteLine();
    }

    public static void PlayGreetingWithAsciiSync()
    {
    string audioPath = "greeting.wav";

    try
    {
        using (SoundPlayer player = new SoundPlayer(audioPath))
        {

        Thread audioThread = new Thread(() =>
        {
            player.PlaySync(); 
        });

        Thread asciiThread = new Thread(() =>
        {
            Console.Clear();
            DisplayAsciiArt();
        });

        // Start both threads almost at the same time
        audioThread.Start();
        asciiThread.Start();

        // Wait for both to finish
        audioThread.Join();
        asciiThread.Join();
    }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Audio error: " + ex.Message);
        DisplayAsciiArt();
    }
  }