using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activites3W : MonoBehaviour
{

    public float distanceToFollow = 5;
    public GameObject objectToFollow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float distance = 100;

        // Work out the distance
        Vector3 pointA = transform.position; // Point A is the cubes position
        Vector3 pointB = objectToFollow.transform.position; // Point B is the spheres position

        distance = Vector3.Distance(pointA, pointB);

        if(distance > distanceToFollow) { // Move the cube

            // Vector3.MoveTowards

        }

    }

    private void OnDrawGizmos() {
        Gizmos.DrawWireSphere(objectToFollow.transform.position, 5f);
    }

}

