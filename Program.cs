using System;
using System.Collections.Generic;
using CsharpDay1.Models;

namespace CsharpDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            // NOTE Explicitly typed
            string name = "Darryl";
            string whatevs;
            char letter = 'H';
            string multiline = @"this is on two
            lines";
            string interpolation = $"Helol, my name is {name}";
            bool exists = false;
            // NOTE implicitly typed
            var isAlive = true;

            // Number this does not exist

            short shortNumber = 10000;
            long longerNumber = 1000000000000000000;
            int age = 1000000000;
            double temperature = 87.2;
            float velocity = 10.4f;
            // NOTE implicit conversion from int to double
            double whatever = velocity;
            float something = age;
            decimal money = 10.0000000010m;

            // Console.BackgroundColor = ConsoleColor.Green;
            // Console.ForegroundColor = ConsoleColor.Magenta;

            // for (int count = 0; count < 11; count++)
            // {
            //     Console.WriteLine(count);
            // }

            // NOTE you dont have to specify the 4 if you provide the values it will determine the length of the array
            string[] dogs = new string[4] { "Scout", "Solo", "Fido", "Bilbo Waggins" };

            List<string> myDogs = new List<string>();

            myDogs.Add("Solo");
            myDogs.Add("Scout");
            myDogs.Add("Fido");

            // NOTE set to false to use calculator
            bool running = false;

            while (running)
            {
                Console.Clear();
                System.Console.WriteLine("You can see these dogs:");
                myDogs.ForEach(dog =>
                {
                    System.Console.WriteLine(dog);
                });

                Console.WriteLine("Press 1 to add a dog, press 2 to pet a dog, press 3 to leave the dogos.");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        System.Console.WriteLine("Which dog do you want to add?");
                        myDogs.Add(Console.ReadLine());
                        System.Console.WriteLine("You added a dogo!");
                        break;
                    case "2":
                        Console.WriteLine("Which dog you do want to pet.");
                        userInput = Console.ReadLine();
                        string dog = myDogs.Find(d => d.ToLower() == userInput.ToLower());
                        if (dog == null)
                        {
                            System.Console.WriteLine($"There is no dog named {userInput}.");
                            Console.ReadLine();
                            continue;
                        }
                        Console.WriteLine($"You pet {dog}.");
                        break;
                    case "3":
                        running = false;
                        break;
                    default:
                        System.Console.WriteLine("I dunno what you want.");
                        break;
                }
                Console.ReadLine();

            }


            Calculator calculator = new Calculator("My calculator");
            // NOTE our title property has a private setter
            // calculator.Title = "something else";
            // string userInput = Console.ReadLine();
            System.Console.WriteLine(calculator.Add(12, 14));
            System.Console.WriteLine(calculator.Add("12", "20"));

            Random randomizer = new Random();
            int randomNumber = randomizer.Next(1, 101);
        }
    }
}

