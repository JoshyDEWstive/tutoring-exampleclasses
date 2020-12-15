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

        ////////////////////////////////////////////////////////////////////////
        // Main methods

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

        private void DoMath(int a, int b)
        {
            return a + b;
        }
    }

}