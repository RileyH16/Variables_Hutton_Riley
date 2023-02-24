using System;

namespace Variables_Hutton_Riley
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declares an integer to store a favorite number
            int favoriteNumber;
            // Booleans initialized to false for running and jumping
            bool isJumping = false, isRunning = false;
            // Declared random float variable 
            float myFloat;
            // Assigning the favoriteNumber to 16
            favoriteNumber = 16;
            // Assigning myFloat to 69.42
            myFloat = 69.42f;
            // Initializing constant finalGrade to 95
            const double finalGrade = 95.0;

            // Prints all variables to console
            Console.WriteLine("Favorite Number: " + favoriteNumber);
            Console.WriteLine("Jumping: " + isJumping);
            Console.WriteLine("Running: " + isRunning);
            Console.WriteLine("Random Floating Number: " + myFloat);
            Console.WriteLine("Final Grade: " + finalGrade);
        }
    }
}
