// See https://aka.ms/new-console-template for more information
using System;
namespace Numberguessing{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("-------------------------");
            Console.WriteLine("  NUMBER GUESSING GAME   ");
            Console.WriteLine("-------------------------");
            int score = 0;
            Random random = new Random();
            

            while (true){
                Console.Write("Do you want to Exit or not(Y/N): ");
                char letter = Convert.ToChar(Console.ReadLine());
                if (letter == 'Y'){
                    Console.WriteLine("Thank you!");
                    break;
                }
                Console.Write("Guess your number(1-100): ");
                int num = Convert.ToInt32(Console.ReadLine());

                int guess = random.Next(1,101);
                Console.WriteLine($"Computer guess : {guess}");
                if (num == guess){
                    Console.WriteLine("Hurray You got one");
                    score += 1;
                }else if(num > guess && num <= 100){
                    Console.WriteLine("Number is greater than guess");
                }else if(num < guess && num >= 0){
                    Console.WriteLine("Number is less than guess");
                }else{
                    Console.WriteLine("Too bad guess");
                    score -= 1;
                }
            }
            Console.WriteLine($"Your score : {score}");

        }
        
        }
    }
