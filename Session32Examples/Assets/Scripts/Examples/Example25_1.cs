
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example25_1 : MonoBehaviour
{
    // Trigger Colliders

    // You do not need any fancy variables to access the trigger collider
    // All you have to is have the script on the same game object

    // Examples of use
    // Detecting where a player is
    // AI (enemies detecting a player)
    // Alarms
    // Scoring
    // Area warnings (entering wrong area)
    // Automatics lights
    // Controlling music

    // This method will activate if something has gone inside the collider (only once - so when it enters)
    private void OnTriggerEnter(Collider other) {
        Debug.Log("Entering the collider");
    }

    // This method will activate once the object has stopped colliding
    private void OnTriggerExit(Collider other) {
        Debug.Log("Exiting the collider");
    }

    // This method will activate while the object is colliding
    private void OnTriggerStay(Collider other) {
        Debug.Log("Inside the collider");
    }

}
