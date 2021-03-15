using System;


// If Statements | C# | Tutorial 14

namespace CSharpExercises_14
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = false;
            bool isTall = false;

            // using AND operator - both of the variables need to be true for the AND to work
            if (isMale && isTall)

            // using OR operator - only one of the variable need to be true for the OR to work
            //if (isMale || isTall)
            {
                Console.WriteLine("You are a tall male");

                //Console.WriteLine("You are either male or tall or both");
            }
            // ! is the negation operator
            else if (isMale && !isTall) {
                Console.WriteLine("You are a short male");
            }
            else if (!isMale && isTall) {
                Console.WriteLine("You are not male but you are tall");
            }
            else                        {
                Console.WriteLine("You are not a male and you are not tall");
            }

            Console.ReadLine();
        }
    }
}
