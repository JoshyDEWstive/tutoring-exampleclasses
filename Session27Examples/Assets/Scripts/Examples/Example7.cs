using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// You can't forget this when using text mesh pro objects
using TMPro;

public class Example7 : MonoBehaviour
{


    //////////////////////////////////////////////////////
    // Session 18 Example 7

    // Updating the text on an object
    public TextMeshProUGUI textObject;

    public void UpdateText(string toUpdate) {
        textObject.text = toUpdate;
    }

    // Debug to the console what mouse button was pressed
    public void GetMouseButtonPressed() {

        Input.GetMouseButton(0); // Returns true whenever the mouse button is held down
        Input.GetMouseButtonDown(0); // Returns true when the player first presses their mouse
        Input.GetMouseButtonUp(0); // Returns true when the player releases the button

        // 0 = Left click
        // 1 = Right click
        // 2 = Middile click

        if (Input.GetMouseButtonUp(0)) {
            Debug.Log("Pressed left click.");
        }
        if (Input.GetMouseButtonUp(1)) {
            Debug.Log("Pressed right click.");
        }
        if (Input.GetMouseButtonUp(2)) {
            Debug.Log("Pressed middle click.");
        }

    }

    // Getting what key is pressed
    public void GetKeyPressed() {

        // You can type the name of the key
        if (Input.GetKeyUp("space")) {
            print("Space key was released");
        }

        // Or you can get the keycode variable for the key
        if (Input.GetKeyUp(KeyCode.Space)) {
            print("Space key was released");
        }

    }

    // It is advisable to use GetAxis because...
    // The script below is a simple script for car movement
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;

    public void SimpleMovement() {
        // Get the horizontal and vertical axis.
        // By default they are mapped to the arrow keys.
        // The value is in the range -1 to 1
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        // Make it move 10 meters per second instead of 10 meters per frame...
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        // Move translation along the object's z-axis
        transform.Translate(0, 0, translation);

        // Rotate around our y-axis
        transform.Rotate(0, rotation, 0);
    }

}
