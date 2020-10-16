using System;

namespace Session1Examples
{
    class Example2
    {

        // Introduction to classes, objects and functions
        
		// This integer is only visible to functions and variables inside of this class, objects and other classes outside of this class cannot access it
		private int myHiddenInteger = 4;
		
		// This integer is visible to all the classes and objects inside this namespace (Session1Examples)
		public int myPublicInteger = 2;
	    	
	    	// This is a function
	    	// This function is a public function, which means that it can be used by other classes inside this namespace (Session1Examples)
	    	// Notice the 'void' this means that this function does not return anything
	    	// After the void you will put the function name
	    	// In the brackets you will put your inputs, leave it blank if there is no inputs required
	    	// You will need brackets { } at the start and end of the function
	    	public void MyFunction() {
			
		}
		
		

    }
}
