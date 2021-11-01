using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! What is your favorite school subject?");

            var subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is a tough subject!");
                    break;
                case "science":
                    Console.WriteLine("Science is a tough subject!");
                    break;
                case "english":
                    Console.WriteLine("English is an interesting subject!");
                    break;
                default:
                    Console.WriteLine($"Oh wow! I haven't taken that subject before. {subject} sounds fun!");
                    break;
            }


                Console.WriteLine("So what is your favorite sport?");

                var sport = Console.ReadLine();

                switch (sport.ToLower())
                {
                    case "football":
                        Console.WriteLine("Football is an exciting sport! Roll Tide!");
                        break;
                    case "baseball":
                        Console.WriteLine("baseball is a very fun sport to play! Who do you think will win the world series?!");
                    Console.ReadLine();
                        break;
                    case "golf":
                        Console.WriteLine("Golf is an interesting sport!");
                        break;
                    default:
                        Console.WriteLine($"Oh wow! I haven't taken that subject before. {sport} sounds fun!");
                        break;
                }
            }
        }
    }
