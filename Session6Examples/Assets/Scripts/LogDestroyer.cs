using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogDestroyer : MonoBehaviour
{
    // We can remove the Start and Update methods because we do not need them
    public string toDelete = "Log";

    private GameController _gameController;

    private void Start()
    {
        _gameController = GameController.instance;
    }

    private void OnTriggerEnter(Collider other) {
        // We need to check if the object is a log, and if it is we need to destroy it.

        string objectName = other.name;

        if(objectName == toDelete ) {
            _gameController.IncreaseScore();
            Destroy(other.gameObject);
        }

    }

}
