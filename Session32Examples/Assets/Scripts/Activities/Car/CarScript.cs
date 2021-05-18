using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{

    // Velocity
    // How fast an object is moving (or how much the position changes)
    // The gauge in the car that shows km/h is your velocity 
    // Velocity has direction, while speed does not


    //  Acceleration
    // The change in your velocity
    // If you accelerate, your velocity increases
    // Acceleration has a direction

    // Acceleration will change due to:
    // - By the user manually accelerating the car
    // - Brakes (user slowing down car)
    // - Friction (slows down car over time)

    // To make a basic car script
    // Have the car's velocity and acceleration
    // Change the acceleration based on user inputs
    // Basic friction

    // Variables

    // Variables that need direction such as velocity or acceleration will need to use a Vector3
    // because Vector3 give quantities (floats)  but also a direction, (X,Y,Z)
    //
    // HOWEVER
    //
    // We can add the direction in when we are changing the position

    // How fast the car can accelerate
    public float maxAccelerate = 1f;

    // How fast the car can reverse
    public float maxReverse = 0.5f;

    // How fast the car can decelerate (brake)
    public float maxDecelerate = 1f;

    // How fast the car decelerates due to friction (tyres on road/not accelerating)
    public float maxFriction = 0.1f;

    // Maximum velocity (top speed)
    // We need metres per second (m/s)
    // If you have km/h you need to convert to m/s
    public float topSpeed = 69f;

    // Car status variables
    public bool isBreaking = false;
    public bool isBeeping = false;
    public bool isAccelerating = false;
    public bool isReversing = false;
    public bool isTurning = false;

    // Car components
    // Rigidbody
    public Rigidbody myRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        // Get all of our components
        myRigidbody = GetComponent<Rigidbody>(); // Get rigidbody component

    }

    // Update is called once per frame
    void Update()
    {
        // Get current user inputs
        // You can get inputs from the input manager by  using the method below
        // Input.GetAxis("Brakes");

        // Check if the user is breaking
        if (Input.GetAxis("Brakes") > 0) {
            isBreaking = true;
        } else {
            isBreaking = false;
        }

        // Check if the user is accelerating
        // 1 = accelerate, -1 = reverse, 0 = not doing anything
        if(Input.GetAxis("Vertical") > 0) {
            isAccelerating = true;
            isReversing = false;
        } else if(Input.GetAxis("Vertical") == 0) {
            isAccelerating = false;
            isReversing = false;
        } else if(Input.GetAxis("Vertical") < 0) {
            isAccelerating = false;
            isReversing = true;
        }
        
        // Check if the user beeps their horn
        if(Input.GetAxis("Jump") > 0) {
            isBeeping = true;
        } else {
            isBeeping = false;
        }

        // Check if the user is turning
        if(Input.GetAxis("Horizontal") != 0) {
            isTurning = true;
        } else {
            isTurning = false;
        }

        // Add friction

        // Then we need to change the acceleration

        // Change the velocity

        // Change the position
    }
}
