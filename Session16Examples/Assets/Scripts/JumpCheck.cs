using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCheck : MonoBehaviour
{

    // This script will be on each log and it will check if the character is too close to a log, if it is then the 
    // level will fail

    private GameController _gameController;

    private void Start() {
        _gameController = GameController.instance;
    }

    // Exactly the same as the Log Destroyer script, but instead of the destroying something, we lose
    // the game
    private void OnTriggerEnter(Collider other) {

        if(other.CompareTag("Player") && _gameController.gameRunning) _gameController.Lose();

    }

}
