using System;

namespace Session1Examples
{

      //////////////////////////////////////////////////////////////////////////////////////////
      // Program Aim
  
      // Demonstrate basic variables, functions and classes by creating a circle object that can return
      // various information about the circle.
  
      // Systems used
      // Arithmetic operators
      // Using the Maths class
      // Using classes and functions
  
      // Introduction of doubles
      // Doubles are basically the same as floats, however it is preferable to use floats.
      // The basic math class uses doubles NOT floats
  
  class Example3 {
  
        public void Example() {

            Circle newCircle = new Circle(5); // Create a circle with a radius of 5

            Console.WriteLine("Value of Pi used: " + Convert.ToString(Circle.Pi)); // Accessing the Circle class (not the newCircle object) and printing the value for Pi
            Console.WriteLine(" "); // New empty line
            Console.WriteLine("Radius of the circle is: " + Convert.ToString(newCircle.radius)); // Accesing the newCircle object and printing its radius
            Console.WriteLine("Diameter of the circle is: " + Convert.ToString(newCircle.GetDiameter())); // Accesing the newCircle object and printing its diameter using its GetDiameter function
            Console.WriteLine("Area of the circle is: " + Convert.ToString(newCircle.GetArea())); // Accesing the newCircle object and printing its area using its GetArea function

        }


  }
  
  // You can have as many Circle objects as you want, each object can have different values for each variables.
  class Circle {
    
    public static double Pi = 3.1415; // You can also use Math.Pi instead of approximating it.
    
    public double radius = 0;
    
    // Instantiating a new class with an input
    public Circle(double _radius) {
      
      // We are using this input to assign a value to one of the class's values
      radius = _radius;
    
    }
    
    // Returns the diameter of the circle
    // d = 2r
    public double GetDiameter() {
      return radius * 2;
    }
    
    // Returns the area of the circle
    // A = (PI)r^2
    public double GetArea() {
      return Pi * Math.Pow(radius,2);
    }
    
  }

}
