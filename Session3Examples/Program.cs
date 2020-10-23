using System;

namespace Calculator_Activity
{
	// This should be called something that is relevant to what the class is doing
    class Program 
    {
		
        static void Main(string[] args)
        { // Make sure to have a space after the first opening and last closing bracket
			
            Console.WriteLine("Please Enter Your First Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
			
			// Another way you can do this
			// This is called casting
			int easyInt = (int) Console.ReadLine();
			
            Console.WriteLine("Please Enter Your Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());
			// int num2 = (int) Console.ReadLine();
			
			// Personal thing, maybe use the symbols (+,- etc) instead
            Console.WriteLine("Plese Enter The Operation You Want To Apply To Your Number");
            Console.WriteLine("To Add (Type add) To Subtract (Type subtract)");
            Console.WriteLine("To Multiply (Type multiply) To Divide(Type divide)");
            Console.WriteLine("NOTE! Your Inputs Are Case Sensitive, Please Use All Lowercase");
            
            string operation = Console.ReadLine();
			
			// We would usually like to avoid having multiple of the same thing (mainly writing to console)
			// You should have a starting variable instead
			float startingVariable;
			
            if (operation == "add")
            {
                //Console.WriteLine(num1 + num2);
				startingVariable = num1 + num2;
            }
            else if (operation == "subtract")
            {
                //Console.WriteLine(num1 - num2);
				startingVariable = num1 - num2;
            }  
            else if(operation == "multiply")
            {
                //Console.WriteLine(num1 * num2);
				startingVariable = num1 * num2;
            }
            else if(operation == "divide")
            {
                //Console.WriteLine(num1 / num2);
				startingVariable = num1 / num2;
            }
			
			Console.WriteLine(startingVariable);
			
        }
		
    }
}
