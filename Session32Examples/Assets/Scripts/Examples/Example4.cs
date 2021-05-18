using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example4 : MonoBehaviour
{
    // Goal:
    // Spawn a random amount of cubes in random positions along a line

    // Define variables
    // Define constants?
    // So maybe we want to have a minimum and maximum amount of cubes we can spawn?
    // So maybe we want to know more about the line? Where is it? How long is it?


    // Make our loops


    public int minimumAmount = 2;
    public int maximumAmount = 10;

    public GameObject cubeToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        // Line will always be at origin to start (0,0) 

        int cubeSpawns = Random.Range(minimumAmount, maximumAmount);

        // A loop that repeats cubeSpawns amount of times

        // While loop

        // Generally you use while loops when you aren't sure how many times something needs to be ran or the condition
        // is not just based on a generic number condition

        int counter = 0;
        while(counter < cubeSpawns) // This loop will keep running while counter is less than cubeSpawns
        {
            // To ensure that the loop is not an infinite loop we need to update the counter value
            counter += 1;

            // We need to decide a location on the line 
            // In this loop we want a line of y = 3 + 0x where x -10 >= 0 <= 10;

            // Find the x value in the line
            int x = Random.Range(-10, 10);

            // Create the vector based on our values
            Vector3 newLocation = new Vector3(x, 3, 0);

            // Spawn our cube
            string cubeName = "Cube " + counter;

            // Define our gameobject we are going to spawn

            GameObject newObject;

            // Instantiate the new object (spawn the object)
            newObject = Instantiate(cubeToSpawn);

            // Tell the object what its name is and where it will go

            newObject.name = cubeName;
            newObject.transform.position = newLocation;

        }

        // For loop

        // Use for loops when you are changing a number in a predictable way and using the outcome to determine the condition
        cubeSpawns = Random.Range(minimumAmount, maximumAmount);
        for (int forCount = 0; forCount < cubeSpawns; forCount += 1)
        {
            // We need to decide a location on the line 
            // In this loop we want a line of y = 6 + 0x where x -10 >= 0 <= 10;

            // Find the x value in the line
            int x = Random.Range(-10, 10);

            // Create the vector based on our values
            Vector3 newLocation = new Vector3(x, 6, 0);

            // Spawn our cube
            string cubeName = "Cube " + forCount;

            // Define our gameobject we are going to spawn

            GameObject newObject;

            // Instantiate the new object (spawn the object)
            newObject = Instantiate(cubeToSpawn);

            // Tell the object what its name is and where it will go

            newObject.name = cubeName;
            newObject.transform.position = newLocation;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
