using System;

namespace Session1Examples
{
    class Example1
    {

        // Introduction into syntax variables, if statements, for loops and white loops
		
        public Example1() // The initialiser function of the class. This will be ran first.
        { //Note how all functions, statements and other collections of code are contained within { } blocks

            //////////////////////////////////////////////////////////////////////////////////////////
            // Syntax

            // First thing to ensure: Every command must be followed by a ';'
            //This is calling the class 'Debug' and running a function called 'WriteLine' and we are passing in a string.

            Console.WriteLine("Hello World!");

            //This function will print "Hello World" to the console

            //////////////////////////////////////////////////////////////////////////////////////////
            // Variables

            //There are four main types of variables in C#
            // Integers (which are real numbers - Any negative or positive number. They cannot have a decimal point)
            // Floats (These are any number, they can have a decimal float)
            // Strings (They are a list of characters, they can be used to form sentences, words or any alphanumeric combination)
            // Boolean (A true or false statement. Yes or No)

            int myInteger = 0; // The shorthand of assigning an integer value is 'int'
            float myFloat = 1.4f; // To assign a float use 'float'. Note that when assigning floats you MUST have a 'f' at the end
            string myString = "Hello"; // To assign a string use 'string'
            bool myBoolean = false; // To assign a boolean use 'bool'

            //////////////////////////////////////////////////////////////////////////////////////////
            // Variable Manipulation

            // Mathematics

            // Arithmetic operators are the same for longs, shorts, floats and integers
            // - is negation and can be used like ' -a '
            // + is addition and can be used like 'a + b'
            // - is subtraction and can be used like 'a - b'
            // * is multiplication and can be used like 'a * b'
            // / is division and can be used like 'a / b'
            // % is modulus (or remainder) and can be used like 'a % b'

            // To find the power of a number you can use the Math library
            int myPoweredInteger = (int) Math.Pow(3, 2); // In this scenario, 3 is raised to the power of 2 (3^2)

            myInteger = myInteger + 6; // This is the long way on how you can use operators on variables
            myInteger += 6; // You can use shorthand terms like += or -= to simplify your code if you are doing a single operation

            // Strings

            // You can also use a + to concatente two or more strings together

            myString = myString + " Apple!";

            // You can also use an inbuilt method for this

            string myFirstString = "Hello ";
            string mySecondString = "Pear!";
            string myNewString = string.Concat(myFirstString, mySecondString);

            // You can find the length of a string my using str.Length - replace str with the name of your string

            int stringLength = myString.Length;

            // You can convert a string to upper or lowercase with

            myString = myString.ToUpper();
            myString = myString.ToLower();

            // Booleans

            // You can inverse (get the opposite) of a boolean by putting a ! at the front of it 

            bool firstBool = true;

            firstBool = !firstBool; //firstBool is now the opposite of TRUE which is FALSE

            //////////////////////////////////////////////////////////////////////////////////////////
            // If Statements

            //This is an if statement. It takes in comparison operators and then determines if they are true or false.
            // If the statement's conditions are met then the statement will run. If they are not met then the else statement will be ran instead.
            // In C# the main comparison operators are
            // == Equal to
            // != not Equal to
            // >= Greater or equal to
            // <= Less or equal to
            // > Greater than
            // < Less than

            // This statement will compare the 'myString' variable to a string defined as 'Hello Apple!'
            // If myString is equal to 'Hello Apple' then the program will output 'He said apple!' in console
            // if myString is not equal to 'Hello Apple' then the program will output 'He didn't say apple!'

            Console.WriteLine(myString);
            if (myString == "hello apple!") {
                Console.WriteLine("He said apple!");
            } else {
                Console.WriteLine("He didn't say apple!");
            }

            //////////////////////////////////////////////////////////////////////////////////////////
            // Arrays

            // Arrays are a collection of diffrent values in a single variable
            // Arrays must be initialised before they can be used
            // Array indexs start at 0

            // the indexes in this array begin at 0 and end at 9
            int[] myArray = new int[10]; // This will create a one-dimensional integer array with a length of 10. 

            // You can also predefine the values with { } brackets

            int[] mySecondArray = { 1, 2, 3, 4 };

            // You can also update elements in the array by:

            myArray[3] = 6; // 3 is the Index (the location in the array) and 6 is what we are setting the index's value to.

            // You can get the value by

            int newValue = myArray[3];

            //////////////////////////////////////////////////////////////////////////////////////////
            // For loops

            // This loop will start at 0 and keep incrementing by one until the middle condition ( i < length) is met.

            int length = 10;
            // Assign the increment variable to (int i = 0)
            // Condition to stop at (i < length)
            // How much to increment the variable (i++) (i++ > i = i + 1)
            for (int i = 0; i < length; i++) {

                string output = "Count: " + Convert.ToString(i); // This converts the increment (i) to a string then adds a 'Count: ' to the front of it
                Console.WriteLine(output); // This displays our new found variable

            }

            //////////////////////////////////////////////////////////////////////////////////////////
            // While loops


            // The while loop will keep running until the condition provided is met.
            // The loop below is the same as the for loop above.

            int whileCount = 0;
            int whileLength = 10;

            while(whileCount <  whileLength) { // Will keep running while this condition is true

                whileCount++; // This will increment the whileCount variable so the loop is not suck in an infinite loop

                string output = "Count: " + Convert.ToString(whileCount); // This converts the whiteCount variable to a string then adds a 'Count: ' to the front of it
                Console.WriteLine(output); // This displays our new found variable

            }

        }

    }
}
