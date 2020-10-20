using System;
using System.Collections;

namespace Session2Examples
{

    ////////////////////////////////////////////////////////////////////////////////////////
    //
    // Objects,  lists and more Loops
    //
    
    public class Example2
    {

        ////////////////////////////////////////////////////////////////////////////////////////
        // Catching up

        // Variables

        // The variable type is called Type. 
        // The name of the variable is the initialiser
        // Public is the access level

        public Type initialiser; 

        public Example2() {

            ////////////////////////////////////////////////////////////////////////////////////////
            // Objects
            //

            // Each variable type you assign will be inherited off of the Object class.
            // Inheritence means that the class will 'inherit' all the variables and methods of the other class.

            // Objects have a few functions that can be very useful
            Object myObject  = new Object();
            myObject.ToString(); // This will return a string version of the object. This is a better method than using Convert.ToString();
            myObject.GetType(); // This will return the type of the object

            // For example, the int class inherits Object
            int myTestInteger = 20;
            string myNewNumber = myTestInteger.ToString(); 
            Console.WriteLine(myNewNumber);
            // Creating the new string variable above is not required you could skip that line and put it in the WriteLine method
            Console.WriteLine(myTestInteger.ToString());
            // The Console.WriteLine function can take most types without needing to convert them to strings
            Console.WriteLine(myTestInteger);

            ////////////////////////////////////////////////////////////////////////////////////////
            // Lists

            // If you to use lists you have to import System.Collections first.
            // A list is basicaly like an array however there are some major differences
            // In an array you have to assign how long you want it to be, in a list a you don't have to do that.

            ArrayList<int> myList = new ArrayList<int>();
            int[] array = { 2, 3, 4 };

            // To get the length of an array 
            array.Length;
            // HOWEVER this is different for lists
            myList.Count;

            array[0] = 2; // Assigning values for an array

            // Add values to a list
            myList.Add(2);

            // Remove the first value from the list
            myList.Remove(2);

            // To get the index of value in the list
            myList.IndexOf(2);

            // You can also remove at an index
            myList.RemoveAt(0);

            // You want to try and always use arrays if the length of them does not change
            // However, if the length will keep changing, it is advised to use a list

            ////////////////////////////////////////////////////////////////////////////////////////
            // Foreach loops

            // They are like for loop but they are mainly used to loop through lists

            foreach(int value in myList) {
                Console.WriteLine(value);
            }

            ////////////////////////////////////////////////////////////////////////////////////////
            // Getting user inputs from console

            Console.WriteLine("==================");
            Console.WriteLine("What is your name: ");

            string name = Console.ReadLine();

            Console.WriteLine("Your name is " + name);

        }

    }

}