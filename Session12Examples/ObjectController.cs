using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ObjectController : MonoBehaviour
{
    // Get the start and end positions
    public GameObject startPosition;
    public GameObject endPosition;

    // How fast we want the object to move
    public float moveSpeed= 1f;
    public float lineOffset = 0.5f;
    // A list  of all the objects to move
    public List<GameObject> _objectsToMove;

    // This is our prefab to spawn
    public GameObject cubePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
        // Initialise the list

        _objectsToMove = new List<GameObject>();

        // Find all the objects that we need to move
        // These objects have the MovingObject tag (Don't forget to
        // add that if you are using this script!)
        GameObject[] currentMovingObjects = GameObject.FindGameObjectsWithTag("MovingObject"); // Get all current moving objects in the scene
        
        // Loop through the array and add it to the list
        for (int i = 0; i < currentMovingObjects.Length; i++) {
            // Add object to the list
            _objectsToMove.Add(currentMovingObjects[i]);
            
            // Error: All the objects are starting in the same position and there is no space between
            // We need to think about how we can actually separate these objects
            // We can add a offset to the objects to actually make a line of them
            // You will notice that this is alot easier to do than a whole bunch of if statements

            // Set the start position of the object
            currentMovingObjects[i].transform.position = startPosition.transform.position - new Vector3(0,0,i * lineOffset);
        }


    }

    // This method will let us add new objects to our list
    // What do we need to do?
    // We need to add it to our list of objects
    //  Set the position of the object
    public void NewObject(GameObject obj) {
        // Add it to our list of objects
        _objectsToMove.Add(obj);

        // Set its position
        // Where?
        // Do we set it to the start position or do we make it go behind the other objects if there is any?

        if(_objectsToMove.Count > 1) { // There is other objects the object could go behind
            int i = _objectsToMove.Count - 1; // Converting out count to an index by taking 1 off of it
            // OBJECT POSITION = START POSITION TAKE OFFSET

            // Getting the object behind this object and then getting its position
            int behindIndex = i - 1; // Get the index of the object behind the object
            Vector3 startingPosition = _objectsToMove[behindIndex].transform.position; // Getting the position to start 
            Vector3 offset = new Vector3(0, 0, lineOffset); // Setting the offset
            obj.transform.position = startingPosition - offset;

        } else { // There is no other object the object could go behind
            obj.transform.position = startPosition.transform.position;
        }

    }

    // Update is called once per frame
    void Update()
    {

        // TODO: Make it when you press C, it will spawn a new cube that will follow the script

        // To create a listener for a key press you need to make an IF statement and put the Input method inside of that
        if(Input.GetKeyDown(KeyCode.C)) {

            // To spawn a new cube
            // The way you create (Instanitiate) GameObjects through scripts in Unity you will need something called a Prefab
            // When you are creating a prefab you need to make sure that you do have a GameObject Variable that contains it
            GameObject newGameObject = Instantiate(cubePrefab);

            // We created a Method early that will run when an object is created, lets test it here!
            NewObject(newGameObject);

        }

        // Move each object towards the end position
        foreach(GameObject go in _objectsToMove)
        {
            // See https://docs.unity3d.com/ScriptReference/Vector3.MoveTowards.html

            go.transform.position = Vector3.MoveTowards(go.transform.position, endPosition.transform.position, moveSpeed * Time.deltaTime);
        }

        // If the object is at the end position, remove it from the list and destroy it
        foreach (GameObject go in _objectsToMove)
        {
            // Error: It didnt break the code, so keep that in mind!
            // But what happened was that we trying to access a variable (go)
            // This does work but it is bad practice to still use a value that has been removed from its list
            // To fix this we can simply assign another variable to the same value

            if(Vector3.Distance(go.transform.position,endPosition.transform.position) <= 0.001f) {
                GameObject nGO = go; // We have created another variable based on the go variable and we have used that to destroy the Game Object
                Destroy(nGO);
                _objectsToMove.Remove(go);
            }

        }


    }
}
