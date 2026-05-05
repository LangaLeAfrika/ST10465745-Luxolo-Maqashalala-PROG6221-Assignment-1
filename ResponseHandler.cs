using System;

namespace CyberSecurityBot
{
    public static class ResponseHandler
    {za
        public static string GetResponse(string input)
        {
            input = input.ToLower();

            if (input.Contains("how are you"))
                return "I'm just code, but I'm here to keep you safe online!";

            if (input.Contains("purpose"))
                return "My purpose is to help you understand cybersecurity and stay safe online.";

            if (input.Contains("password"))
                return "Use strong passwords with letters, numbers, and symbols. Never share them!";

            if (input.Contains("phishing"))
                return "Phishing is when attackers trick you into giving personal info. Always check links!";

            if (input.Contains("safe browsing"))
                return "Only visit secure websites (https), avoid suspicious downloads.";

            if (input.Contains("what can i ask"))
                return "You can ask about passwords, phishing, and safe browsing.";

            return "I didn't quite understand that. Could you rephrase?";
        }
    }
}