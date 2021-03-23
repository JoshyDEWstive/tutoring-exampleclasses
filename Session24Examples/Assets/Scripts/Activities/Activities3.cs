using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activities3 : MonoBehaviour
{

    ////////////////////////////////////////////////////////////
    // Activity 3
    // Goal:
    // Get this script to move towards a game object at a distance
    // of atleast 5 metres

    // The starting variables have been made for  you

    public float distanceToFollow = 5;
    public GameObject objectToFollow;

    // Your variables if required

    public Transform followTransform;
    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        followTransform = objectToFollow.transform;
    }

    // Update is called once per frame
    void Update()
    {
        // The positions of the game objects have been put into separate variables for ease of reading
        Vector3 myPosition = transform.position;
        Vector3 followPosition = followTransform.position;
        
        // Get the distance between the two variables
        float distance = Vector3.Distance(myPosition,followPosition);
        
        // Move the object closer if the distance is greater or equal to the distance to follower
        if(distance >= distanceToFollow)
        {
            transform.position = Vector3.MoveTowards(myPosition, followPosition, speed * Time.deltaTime);
        }

    }

    private void OnDrawGizmos() {
        Gizmos.DrawWireSphere(objectToFollow.transform.position, 5f);
    }

}
