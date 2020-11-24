using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    // Get the start and end positions
    public GameObject startPosition;
    public GameObject endPosition;

    // How fast we want the object to move
    public float moveSpeed= 1f;

    // A list  of all the objects to move
    private List<GameObject> _objectsToMove;

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

            // Set the start position of the object
            currentMovingObjects[i].transform.position = startPosition.transform.position;
        }


    }

    // Update is called once per frame
    void Update()
    {

        // Move each object towards the end position
        foreach(GameObject go in _objectsToMove)
        {
            // See https://docs.unity3d.com/ScriptReference/Vector3.MoveTowards.html

            go.transform.position = Vector3.MoveTowards(go.transform.position, endPosition.transform.position, moveSpeed * Time.deltaTime);
        }

        // If the object is at the end position, remove it from the list and destroy it
        foreach (GameObject go in _objectsToMove)
        {
            if(Vector3.Distance(go.transform.position,endPosition.transform.position) <= 0.001f) {
                _objectsToMove.Remove(go);
                Destroy(go);
            }

        }


    }
}
