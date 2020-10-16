using System;

namespace Session1Examples
{
    class Activity1
    {
        //////////////////////////////////////////////////////////////////////////////////////////
        // Activity one
        //
        // Write a function which returns the largest number in an array of numbers given
        //
        // Input
        // int[] cases (An integer array filled with random numbers) 1 >= x <= 100 (between 1 and 100 inclusive)
        //
        // Output
        // The largest number in the list

        public static void Main(string[] args) {

            int[] cases = GetTestCases();

            // Write a function which returns the largest number in an array of numbers given


        }

        public static int[] GetTestCases() {

            Random rnd = new Random();

            int[] output = new int[rnd.Next(1,100)];

            for (int i = 0; i < output.Length; i++) {
                output[i] = rnd.Next(1, 100);
            }

            return output;
        }

    }
}
