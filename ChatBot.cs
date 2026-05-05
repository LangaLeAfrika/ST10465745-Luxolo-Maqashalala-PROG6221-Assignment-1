using System;

namespace CyberSecurityBot
{
public class ChatBot
{
    public string UserName { get; set; }

    public ChatBot(string name)
    {
        UserName = name;
    }

    public void StartChat()
    {
        Console.Clear();
        UIHelper.DisplayAsciiArt();
        Console.WriteLine($"Welcome {UserName} to the Cybersecurity Awareness Bot!\n");

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"{UserName}: ");
            Console.ResetColor();

            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("⚠ Please enter something.");
                continue;
            }

            if (input.ToLower() == "exit")
            {
                Console.WriteLine("👋 Goodbye! Stay safe online.");
                break;
            }

            string response = ResponseHandler.GetResponse(input);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Bot: {response}\n");
            Console.ResetColor();
        }
    }
}
}