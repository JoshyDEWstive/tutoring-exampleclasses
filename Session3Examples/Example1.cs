using System;
using UnityEngine; // This script would only work in Unity

namespace Tutoring.Session3.Example1
{
    class Program
    {
		
		///////////////////////////////////////////////////////////////////////////
		// ENUMS
			
		// Enums are a way to create human readable states for objects
		// You create an enum then you create a variable that uses that enum
			
		// This creates an enum called Animal Types and creates some animals inside them. Note how they do not have to be strings
		// Note the use of pascal casing here
		
		public enum AnimalTypes {
				GOAT,
				COW,
				SHEEP,
				CHICKEN,
				TALL_GOAT // You can't use spaces you have to use underscores
		}
			
		// This creates a new variable called myAnimalType and sets the value to AnimalTypes.Goat
		public AnimalTypes myAnimalType = AnimalTypes.GOAT;
			
		// You can actually assign values to enums
		
		public enum Difficulties : int {
			EASY = 1,
			MEDIUM  = 2,
			HARD = 3
		}
		
		// So you can still access your difficulty enum like normal
		public Difficulties gameDifficulty = Difficulties.EASY;
		
        static void Main(string[] args)
        {
            
			Console.WriteLine(Difficulties.MEDIUM);
			
			///////////////////////////////////////////////////////////////////////////
			// VECTORS
			
			// Vector3 
			
			// Vector3s are a way of storing three values, they are usually used to store a position 
			// either in an array or in the world
			
			// Vector3s take three different inputs to create
			// X - Forwards and back (+ve is forwards, -ve is backwards)
			// Y - Up and Down (+ve is up, -ve is down)
			// Z - Left and Right (+ve is left, -ve is right)
			
			// Replace X, Y, Z with your variables
			// The X,Y,Z values should be floats
			
			float x = 4;
			float y = 2;
			float z = 0;
			
			Vector3 myVector = new Vector3(x,y,z);
			
			// This is how you get the values inside of your vector
			myVector.x;
			myVector.y;
			myVector.z;
			
			// Vectors comes with functions that you can use
			
			myVector.Distance(vector); // this will return a float of the distance between the two vectors
			
			// You can do arithmetic with vectors
			
			Vector3 vectorA = new Vector3(); // This would mean that x, y and z are all 0
			Vector3 vectorB = new Vector3(5,2,1);
			
			Vector3 vectorC;
			
			vectorC = vectorA + vectorB;
			vectorC = vectorA - vectorB; //etc
			
			// Although a thing to remember is that there is no power of other math functions avaliable for vectors and you'll have to make them yourself
			
			// Vector2s can do all the same things a vector3 can, except they do not have a third value.
			Vector2 my2DVector = new Vector2(x,y);
			
        }
    }
	
}
