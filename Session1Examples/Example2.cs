using System;

namespace Session1Examples
{

    class Example2 {

        // Introduction to classes, objects and functions

        //////////////////////////////////////////////////////////////////////////////////////////
        // Object visibility 

        // This integer is only visible to functions and variables inside of this class, objects and other classes outside of this class cannot access it
        private int myHiddenInteger = 4;

        // This integer is visible to all the classes and objects inside this namespace (Session1Examples)
        public int myPublicInteger = 2;

        public Example2() {

            // This will call the function that we created below and everything inside that function will be ran before the next line
            MyFunction();

        }

        //////////////////////////////////////////////////////////////////////////////////////////
        // Functions

        // This is a function
        // This function is a public function, which means that it can be used by other classes inside this namespace (Session1Examples)
        // Notice the 'void' this means that this function does not return anything
        // After the void you will put the function name
        // In the brackets you will put your inputs, leave it blank if there is no inputs required
        // You will need brackets { } at the start and end of the function
        public void MyFunction() {
            Console.WriteLine("I am a function");
        }

        // Static functions can be ran without initialisation of the class
        // They cannot access non-static variables and functions
        public static void MyStatic() {
            Console.WriteLine("This function can be ran without initialisation of the class");
        }

        //////////////////////////////////////////////////////////////////////////////////////////
        // Classes

        // This will create a new instance of the Example2A class 
        // You can now access the variables and functions and change them at will
        // You can call them my using the variableName DOT the function or variable name

        // New instance of Example2A class created as a variable called myOtherClass (This is an object)

        public void ClassExample() {

            Example2A myOtherClass = new Example2A();

             string output = "The number is: " + Convert.ToString(myOtherClass.myTestNumber);
             Console.WriteLine(output);
	    	
	        myOtherClass.DisplayNumber();
		
	        // Accessing static function from another class
	        // CLASSNAME.FUNCTION()

	        Example2A.ICanBeRanAnywhere();
        }

     }
	
	// This is a new class, it will contain its own functions and variables
	class Example2A {
	
		public int myTestNumber = 16;
		
		public void DisplayNumber() {
			Console.WriteLine("Number: " + Convert.ToString(myTestNumber));
		}
		
		public static void ICanBeRanAnywhere() {
			Console.WriteLine("I do not require an initialised class to be run");
		}
		
	}
	
}
