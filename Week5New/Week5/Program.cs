using System;

namespace Week5Assig_
{
    class Program
    {
        static void Main(string[] args)
        {
            ProblemTwo();
            ProblemFour();
            ProblemOne();
        }


        static void ProblemTwo()
        {
            var sum = 0;
            bool continueLoop = true;

            while (continueLoop)
            {

                Console.WriteLine("Enter a number, enter OK to exit: ");

                String ans = Console.ReadLine();
                if (ans == "ok" || ans.ToLower() == "ok")
                    continueLoop = false;

                else
                {
                    sum += Convert.ToInt32(ans);
                }


                Console.WriteLine(sum);
            }
        }





        static void ProblemFour()
        {

            int allowedTries = 4;
            int numberOfTries = 0;
            int randomNumber = 0;
            Console.WriteLine("Guess a number, if it's the same as the computer's you win");

            while (numberOfTries < allowedTries)
            {

                int pGuess = GetGuess();
                numberOfTries++;
                if (pGuess == randomNumber)

                {
                    Console.WriteLine("You Won");
                    numberOfTries = allowedTries;

                }

                if (pGuess > randomNumber)
                {
                    Console.WriteLine("You lost");
                    numberOfTries = allowedTries;
                }

                if (pGuess < randomNumber)
                {
                    Console.WriteLine("You lost");
                    numberOfTries = allowedTries;
                }
                

                if (numberOfTries == allowedTries)
                {
                    Console.WriteLine("The number was:" + randomNumber);
                }

                {

                    Console.Write($"You have { allowedTries - numberOfTries}  tries left. Enter another number:");

                }

            }

        }

        public static int GetGuess()
        {
            int guess = 0;
            try

            {
                guess = Convert.ToInt32(Console.ReadLine());
            }

            catch (Exception)

            {
                Console.WriteLine("You ran out of guesses.");
                guess = GetGuess();
            }
            return guess;
        }



        static void ProblemOne()
        {

            Run();
            

        }

        public static void Run()
        {
            Console.WriteLine("Numbers divisible by 3: " + numDivByThree());
        }

        public static int numDivByThree()
        {

            var count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                    count++;
                }
            }
            return count;
        }

    }
}