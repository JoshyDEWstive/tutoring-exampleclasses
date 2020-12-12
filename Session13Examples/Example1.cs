using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example1 : MonoBehaviour
{
    ////////////////////////////////////////////////////////////////
    // SCOPE and VARIBLES

    // When you define a variable in C# you must ensure that you make sure you set the object type, 
    //the initialiser (the name) and if required the scope.

    //The scope only needs to defined when it is inside the class but outside of a method.

    // Example 1A
    // Public is the scope (also referred to as the protection or privacy level)
    // int is the object type
    // amountOfCats is the name
    // 40 is the default/starting value
    public int amountOfCats = 40;

    // Example 1B
    // Public is the scope (also referred to as the protection or privacy level)
    // static is a modifier that belongs to the type and not the specific object (you do not need an Example1 object defined to access
    // a static variable)
    // int is the object type
    // amountOfDogs is the name
    // 2 is the default/starting value
    public static int amountofDogs = 2;

    // Example 1C

    public void TestMethod1()
    {
        // Notice that we do not have the scope section added to this variable
        // Variables declared inside of methods (and in general, it is always best practice to write public/private though)
        // are default set to private
        int amountOfPotatoes = 3;
    }

    ////////////////////////////////////////////////////////////////
    // For Loops
    
    // Example 2A
    public void TestMethod2()
    {
        // Create an initialiser variable called 'i'
        // Only run if 'i' is less than 10
        // Increase 'i' by one every time the loop is ran
        for(int i = 0;i < 10;i++)
        {
            Debug.Log(i);
        }

    }

    ////////////////////////////////////////////////////////////////
    // While Loops

    // Example 3A
    public void TestMethod3()
    {
        // Only run the while loop while increment is less than 10
        int increment = 0;
        while(increment < 10)
        {
            // Increment the increment variable by one
            increment += 1;
            Debug.Log(increment);
        }
        // It is important to make sure that the loop is not an infinite loop otherwise your game will break!
    }


}
