using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example6 : MonoBehaviour
{
    ////////////////////////////////////////////////////////////
    // Distance and moving towards

    // This will return the distance (how far apart) two objects are
    // You should try not to use this function because it can cause lag but for now it is okay.
    public float GetDistance(Vector3 objectA,Vector3 objectB)
    {     
        return Vector3.Distance(objectA, objectB);
    }

    // It is better to use this method when comparing distances because you don't need to know the distance
    // when comparing, just what is bigger than what
    // This will return the square of the distance
    public float GetDistanceSquared(Vector3 objectA,Vector3 objectB)
    {
        Vector3 offset = objectA - objectB;
        return Vector3.SqrMagnitude(offset);
    }

    // This method will will move an object closer to another object at a desired speed
    public void MoveTowardsObject(Transform objectToMove, Transform moveTo, float speed)
    {
        // Make sure to always include the Time.deltaTime multiplication otherwise the method will work too fast for the player
        // and it will not be smooth

        // The Vector3.MoveTowards method will return a vector that is on a line between the two objects, this vector
        // will be (speed * Time.deltaTime) closer to the target
        objectToMove.position = Vector3.MoveTowards(objectToMove.position, moveTo.position, speed * Time.deltaTime);
    }

}
