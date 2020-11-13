using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class GameController : MonoBehaviour
{

    // This game controller will be controlling all the big aspects of the game such as
    // When the game is spawning logs
    // Also the UI (user interface Note: Usually the user interface is controlled by a separate UIController script, however
    // because this game is very basic, we don't need to use it because it will overcomplicate things)
     
    public int score; // This score will increase everytime the player jumps over a log
    public int goal = 10; // We will win the game when we reach this score

    public bool gameRunning = true;
    public bool canGetPoints = true;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI goalText;
    public GameObject losePanel;
    public GameObject winPanel;

    private LogSpawner _logSpawner;

    // This will be the variable that contains where the player is at the start of the game
    private Vector3 _characterStartPosition;
    private Quaternion _characterStartRotation;

    // Instancing
    // Making a script static so that every other component in the game can find the script
    public static GameController instance = null;

    private void Awake()
    {
        // Setting the instance of the gamecontroller to this component if the instance has
        // not already been sent
        if (instance == null) instance = this;
        else Debug.LogError("There is more than one Game Controller on the scene!");
    }

    // Start is called before the first frame update
    void Start() {

        // We are getting the log spawner component
        _logSpawner = GetComponent<LogSpawner>();

        // Hide the lose and win panel
        losePanel.SetActive(false);
        winPanel.SetActive(false);

        // Finding the player, and finding its transform then getting its position off of that
        _characterStartPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
        _characterStartRotation = GameObject.FindGameObjectWithTag("Player").transform.rotation;

        // Update the UI
        UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {
    
        // If the game is running
        _logSpawner.spawnLogs = gameRunning;

    }

    // TODO: Make the game do something when we lose
    public void Lose() {
        Debug.Log("Lose");
        gameRunning = false;

        // Display TRY AGAIN, then reset score and delete all logs

        // Displaying the lose panel
        losePanel.SetActive(true);

        // Reset score restart the gane
        StartCoroutine(RestartGame(losePanel));

    }

    // TODO: Make the game do something when we WIN
    // When we win, we want to increase the goal by 5 logs and we want them to spawn slightly faster
    public void Win() {
        Debug.Log("Win");
        gameRunning = false;

        goal += 2; // This is a value that will need to be changed over time otherwise the game might become too hard or too easy

        winPanel.SetActive(true);

        // Another thing to note here is that we could also change the formula for the spawn interval
        // for game balance reasons
        // Spawn Interval = 4 * (STARTING_GOAL / CURRENT_GOAL)

        // If our goal is 10 jumps
        // Our spawn interval will be 4 seconds because
        // Spawn Interval = 4 * (10 / 10)
        // Spawn Interval = 4 * 1
        // Spawn Interval = 4 

        // If our goal is 12 jumps
        // Our spawn interval will be 3.32 seconds because
        // Spawn Interval = 4 * (10 / 12)
        // Spawn Interval = 4 * 0.83f
        // Spawn Interval = 3.32

        _logSpawner.spawnLogs = gameRunning; // Ensures that the spawner isnt spawning any more logs

        Debug.Log(goal);
        Debug.Log(4f * (10f / goal));
        _logSpawner.spawnInterval = 4f * (10f / goal);
        Debug.Log(_logSpawner.spawnInterval);

        StartCoroutine(RestartGame(winPanel));
    }

    // Restarts the whole game, destroys the excess logs, waits and resets the score
    IEnumerator RestartGame(GameObject panel)
    {

        // Loop through every gameobject with the tag 'Log' and destroy it
        GameObject[] logs = GameObject.FindGameObjectsWithTag("Log");

        foreach (GameObject go in logs)
        {
            Destroy(go);
        }

        // Get the player
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        // Get the character movement script from the player game object
        CharacterMovement chrMovement = player.GetComponent<CharacterMovement>();

        // Disable character movement
        chrMovement.canMove = false;

        // Wait three seconds
        yield return new WaitForSeconds(3f);

        // Restart the game by setting gameRunning to true and setting the score to 0
        gameRunning = true;
        score = 0;

        // Finally, we want to reset the character's position and enable character movement
        player.transform.position = _characterStartPosition;
        player.transform.rotation = _characterStartRotation;
        chrMovement.canMove = true;

        // We need to hide the provided panel
        // We could of hid the lose and win panel although it is better to avoid using constants in object
        // orientated programming

        panel.SetActive(false);

        // Update the UI
        UpdateUI();

    }

    // Increase the score of the player and update the UI to display the changed score
    public void IncreaseScore() {
        if (gameRunning == false) return;
        if (canGetPoints == false) return;

        // Increase score by one
        score += 1;

        // If we have reached our goal, win the game
        if(score >= goal) {
            Win();
        }

        // Update the UI
        UpdateUI();

    }

    // This method will update the UI with the current values
    public void UpdateUI() {

        scoreText.text = score.ToString();
        goalText.text = goal.ToString();

    }

}
