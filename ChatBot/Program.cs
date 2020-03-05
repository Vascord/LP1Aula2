using System;

namespace ChatBot
{
    class Program
    {
        static void Main(string[] args)
        {
            string question, responce;
            bool exit = false;
            while(true)
            {
                Console.WriteLine("Ask me a question: ");
                question = Console.ReadLine().Trim();
                switch(question)
                {
                    case "Who are you?":
                        responce = "Killer Bean.";
                        break;
                    case "How are you?":
                        responce = "Not so good, I'm kinda grumpy.";
                        break;
                    case "2+2 is 4?":
                        responce = "-1, that's 3, QUICK MATHS!";
                        break;
                    case "What are you doing in my swamp?":
                        responce = "Collecting some onions.";
                        break;
                    case "EXIT":
                        responce = "See ya!";
                        exit = true;
                        break;
                    default:
                        responce = "Put it in a language I can understand.";
                        break;
                }

                Console.WriteLine(responce);

                if (exit)
                    break;
            }
        }
    }
}
