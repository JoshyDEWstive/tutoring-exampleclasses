using System;

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

        }

    }

}