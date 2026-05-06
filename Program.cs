using System;

namespace CyberSecurityBot
{
class Program
{
    static void Main(string[] args)
    {
       
        UIHelper.PrintDivider();

        UIHelper.PlayGreetingWithAsciiSync();

        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(userName))
        {
            Console.Write("Name cannot be empty. Enter your name: ");
            userName = Console.ReadLine();
        }

        ChatBot bot = new ChatBot(userName);
        bot.StartChat();
    }
}
}