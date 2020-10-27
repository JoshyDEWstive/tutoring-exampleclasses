using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterMovement : MonoBehaviour
{

    // Getting all the transforms (gameobjects) that the movement script requires
    public Transform playerBody; // The physical body (the gameobject with the collider) of the character
    public Transform camera; // The camera that the character moves
    public Transform groundCheck; // The game object that checks for ground

    public float jumpHeight = 1f; // How high the character jumps
    public float mouseSensitivity = 100f; // How sensitive the mouse is (how fast you can look around)
    public float walkSpeed = 4f; // How fast the character moves around
    public float gravity = -9.8f; // Gravity (earth is 9.8m/s)

    public LayerMask groundMask; // The layermask that counts as ground
    public float groundDistance = 0.5f; // Size of the ground check collider
    public bool canMove = true; // If false, the script does not update

    private bool isGrounded = false; // Changes when the character is on the ground
    private float _xRotation = 0f; // Current X rotation of the character
    private CharacterController controller; // The character controller
    private Vector3 velocity; // Velocity of the player

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Sets the cursor to be in the middle of the screen
        controller = GetComponent<CharacterController>(); // Gets the game object's character controller script
        camera = Camera.main.transform; // Sets the camera variable to the main camera of the game


    }

    // Update is called once per frame
    void Update()
    {

        if (canMove) MouseLook(); // Runs the MouseLook method if the character can move
        Movement(); // Movement method

    }

    void MouseLook()
    {

        // Getting the Mouse X and Y positions on the screen and multiplies by the sensitivity to change the speed
        // The Time.deltaTime is to ensure it runs smoothly based on real time (without it it would change depending on framerate, eg high frame rate = faster rotation)

        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        
        // Taking the mouseY from the _xRotation (up and down)
        // Clamps the _xRotation to be between -90 and 90 degrees (straight down and straight up)
        _xRotation -= mouseY;
        _xRotation = Mathf.Clamp(_xRotation, -90f, 90f);

        // Rotates the camera by the xRotation and the body by the mouseX rotation.
        camera.localRotation = Quaternion.Euler(_xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);

    }
    void Movement()
    {

        // Checks if the player  is standing on the ground
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        // If the character is on the ground the velocity.y is set to -2f (could be 0 but -2f ensures the character is smoothly stuck to the ground)
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        // Gets the X and Z (WASD or arrow keys) movement
        // ? operator (will explain)
        // If canMove is false then the values are 0
        float x = canMove ? Input.GetAxis("Horizontal") : 0f;
        float z = canMove ? Input.GetAxis("Vertical") : 0f;

        // The move vector relative to the player's position
        Vector3 move = transform.right * x + transform.forward * z;

        // Moves the player relative to the game time
        controller.Move(move * walkSpeed * Time.deltaTime);

        // Sets the velocity of the Y to give enough speed to reach the jump height
        // Vy = -2Hg (where H is jumpHeight and g is gravity)
        // Don't have to worry about the math
        // Only works if you are grounded
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
        }

        // Applies gravity to the character
        velocity.y += gravity * Time.deltaTime;
        // Moves the character by the gravity
        controller.Move(velocity * Time.deltaTime);

    }

}


