using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activities4 : MonoBehaviour
{

    ////////////////////////////////////////////////////////////
    // Activity 4
    // Goal:
    // Using the distance and the square magnitude function find what object is closer to the central object

    // Variables provides

    public Transform objectA;
    public Transform objectB;

    public Transform centralObject;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void DistanceWay()
    {

        // Find the distance between the central object and objectA
        float distanceA = Vector3.Distance(centralObject.position, objectA.position);

        // Find the distance between the central object and objectB
        float distanceB = Vector3.Distance(centralObject.position, objectB.position);

        // Compare the distances and output
        if(distanceA > distanceB) { // A is further than B
            Debug.Log("B is closer");
        } else {
            Debug.Log("A is closer");
        }

    }

    void SqrMagnitudeWay()
    {
        // Calculate the distance between the central object and object A

        Vector3 offsetCA = centralObject.position - objectA.position;
        float distanceA = Vector3.SqrMagnitude(offsetCA);

    }

}
