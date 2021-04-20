using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activities1 : MonoBehaviour
{

    ////////////////////////////////////////////////////////////////
    // Creating new gameobjects in the world using a prefab

    // Tell the script what prefab to spawn (create a variable at the top of the class)
    // Spawn that prefab in the world
    // Then we need to change its properties like where it is, what rotation and any other things 
    // we need to change

    // Make sure this variable is set to public otherwise we will not be able to see it in the
    // inspector

    public GameObject prefabToSpawn;

    public void SpawnObjectTest()
    {
        // When we are spawning a game object we need to create a new variable
        // in the method and use the Instatintiate function to return the default variable (and this function
        // also creates the GameObject).

        // This creates a new variable called newObject which is set to a new object in the world that has been
        // created
        GameObject newObject = Instantiate(prefabToSpawn);
    }

    ////////////////////////////////////////////////////////////////
    // Creating new gameobjects in the world using a prefab then changing its position in the world

    public void SpawnObjectTestChangePosition()
    {
        // When we are spawning a game object we need to create a new variable
        // in the method and use the Instatintiate function to return the default variable (and this function
        // also creates the GameObject).

        // This creates a new variable called newObject which is set to a new object in the world that has been
        // created
        GameObject newObject = Instantiate(prefabToSpawn);

        // To change the position of an object you can access the Transform component

        // Creating a new variable with the type Transform that is set to the Transform component of our newObject
        Transform newTransform = newObject.transform;

        // To change the position of the transform and thus the game object you can do
        newTransform.position = new Vector3(5, 1, 0);
        
        // The problem with what we wrote above is that it is very long and can be simplified down
        // However we only want to do this IF we are changing more than one thing about the component

        newObject.transform.position = new Vector3(7, 3, 0);
        
    }

    ////////////////////////////////////////////////////////////////
    // Creating new empty game objects in the world

    public void SpawnEmptyObjectTest()
    {
        // Empties are gameobjects that do not have any components (except the transform component)
        // when they are created thus they do not need to have a prefab to be spawned
        
        // This creates a new variable called newObject which is set to a new empty object in the world
        // that is called "Empty Object"
        GameObject newObject = new GameObject("Empty Object");
    }

    ////////////////////////////////////////////////////////////////
    // Spawning 10 game objects in a line

    public void SpawnObjectsInWorld()
    {
        // Lets spawn 10 game objects in a line
        // What type of loop do you want to use?
        // Hint: You can use both
        // Let's create a while loop!

        int number = 0;
        while(number < 10)
        {
            
            // Spawn our object

            GameObject objectInLine = Instantiate(prefabToSpawn);

            // Move the object (change the position)

            // We give the position access to the number variable because if we gave it a constant like three
            // all of the game objects would spawn in the same position, however because we know that the number
            // variable increases linearly we can use.
            objectInLine.transform.position = new Vector3(0,0,number);

            // Update the condition
            number += 1;
        }

    }

    ////////////////////////////////////////////////////////////////
    // Making an object move in a wave using Math.Sin

    public void SpawnObjectsInWave()
    {
        int number = 0;
        while (number < 50)
        {

            // Spawn our object

            GameObject objectInLine = Instantiate(prefabToSpawn);

            objectInLine.transform.position = new Vector3(0, 2 * Mathf.Sin(number), number*2);

            // Update the condition
            number += 1;
        }
    }


    ////////////////////////////////////////////////////////////////
    // Creating an empty object and spawning more objects with that empty as a parent

    public void SpawnObjectsInWorldWithParent()
    {
        GameObject parentObject = new GameObject("Wave Parent");

        int number = 0;
        while (number < 50)
        {

            // Spawn our object

            GameObject objectInLine = Instantiate(prefabToSpawn);

            // Setting the objects position
            objectInLine.transform.position = new Vector3(0, 2 * Mathf.Sin(number), number * 2);
            // Setting the object's parent
            objectInLine.transform.SetParent(parentObject.transform);

            // Update the condition
            number += 1;
        }

    }

    ////////////////////////////////////////////////////////////////
    // Functions (ignore)
    public void Start()
    {
        //SpawnEmptyObjectTest();
        //SpawnObjectTest();
        //SpawnObjectTestChangePosition();

        //SpawnObjectsInWorld();

        //SpawnObjectsInWave();

        SpawnObjectsInWorldWithParent();
    }

}
