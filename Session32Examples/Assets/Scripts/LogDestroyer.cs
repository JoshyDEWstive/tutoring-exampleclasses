using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogDestroyer : MonoBehaviour
{
    // We can remove the Start and Update methods because we do not need them
    public string toDelete = "Log";
    public bool isMenu = false;
    private GameController _gameController;

    private void Start()
    {
        // You could of done (isMenu == false)
        // We can use the '!' to say NOT the value
        // if the value is equal to false it becomes true
        // if the value is equal to true it becomes false

        // You can write your if statements on a single line, and the { } brackets are not required but you should use them
        // if you want to
        if (!isMenu) { _gameController = GameController.instance; }

    }

    private void OnTriggerEnter(Collider other) {
        // We need to check if the object is a log, and if it is we need to destroy it.

        string objectName = other.name;

        if(objectName == toDelete ) {

            // Other way you can do it
            if (isMenu == false) { _gameController.IncreaseScore(); }

            Destroy(other.gameObject);
        }

    }

}
