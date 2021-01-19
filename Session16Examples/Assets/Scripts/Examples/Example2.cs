// Copyright things first 

// Implement required namespaces first
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Session14Namespace is the name of the namespace that we want to access
namespace Session14Namespace
{

    // Note that this class inherits the monobehaviour class
    public class Example2 : MonoBehaviour
    {

        ////////////////////////////////////////////////////////////////////////
        // Public variables

        public int randomNumberOne = 2;
        public int randomNumberTwo = 5;

        ////////////////////////////////////////////////////////////////////////
        // Private variables

        private int _randomNumberThree = 9;
        // You can also skip writing 'private' and it will by default be a private variable, but it is common practice
        // to always include the private
        int _randomNumberFour = 42;

        ////////////////////////////////////////////////////////////////////////
        // Main methods
        // Main methods are any method is used frequently by the class and by other classes

        void Start()
        {
            //...
        }

        // Update is called once per frame
        void Update()
        {
            //...
        }

        ////////////////////////////////////////////////////////////////////////
        // Helper methods
        // Helper methods are methods that are used by the main methods to simplify your script to make things quicker
        // and easier to read. They are usually not accessed by other classes outside the namespace.

        private int DoMath(int a, int b)
        {
            int addedNumbers = a + b;
            return addedNumbers;
        }

    }

}