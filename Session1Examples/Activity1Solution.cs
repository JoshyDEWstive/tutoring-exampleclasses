using System;

namespace Session1Examples
{
    class Activity1Solution
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


        public Activity1Solution() {

            int[] cases = GetTestCases();

            // Write a function which returns the largest number in an array of numbers given
            int LargestNumber = ReturnLargestNumber(cases);

            Console.WriteLine(LargestNumber);

        }

        public static int ReturnLargestNumber(int[] cases) {

            // Initialising the value we will use in our loop
            int number = -1;

            // Loop through the cases array
            for (int i = 0; i < cases.Length; i++) {

                // If the number in the array is greater than our number variable, set the number variable to the number in the array
                if(cases[i] > number) {
                    number = cases[i]; 
                }

            }

            // Return our number value
            return number;

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
