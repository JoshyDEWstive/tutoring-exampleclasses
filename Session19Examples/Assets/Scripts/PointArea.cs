using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointArea : MonoBehaviour
{
    // This script is a component of the gameobject that has the trigger collider

    private GameController _gameController;

    // Start is called before the first frame update
    void Start()
    {
        _gameController = GameController.instance;
    }

    // When a gameobject enters the trigger collider
    private void OnTriggerEnter(Collider other) {

        // Checks if the object has the Player tag, if it does, then we we want to let the player get points
        if (other.CompareTag("Player")) _gameController.canGetPoints = true;

    }

    // When a gameobject leaves the trigger collider
    private void OnTriggerExit(Collider other) {

        // Checks if the object has the Player tag, if it does, then we we want to stop the player getting points
        if (other.CompareTag("Player")) _gameController.canGetPoints = false;

    }

}
