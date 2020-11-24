using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterMovement : MonoBehaviour
{

    // This script is basically the same as the 3D version of the script
    // HOWEVER
    // There is no Z movement
    // There is no Camera controls
    // There is no cursor lock
    // Using a rigidbody instead of a character controller

    // What does the character need to do
    // Getting a player input (that would be in the form of a mouse or a keyboard input) and we would use that information to move the character in the scene
    // Horizontal movement is your LEFT and RIGHT arrow keys and your A and D keys (by default)
    // Vertical movement it is your UP and DOWN arrow keys and your W and S keys (by default)

    // Getting all the transforms (gameobjects) that the movement script requires
    public Transform playerBody; // The physical body (the gameobject with the collider) of the character
    public Transform groundCheck; // The game object that checks for ground
    
    public float jumpHeight = 1f; // How high the character jumps
    public float mouseSensitivity = 100f; // How sensitive the mouse is (how fast you can look around)
    public float walkSpeed = 4f; // How fast the character moves around
    public float gravity = -9.8f; // Gravity (earth is 9.8m/s)

    public LayerMask groundMask; // The layermask that counts as ground
    public float groundDistance = 0.5f; // Size of the ground check collider
    public bool canMove = true; // If false, the script does not update

    private bool _isGrounded = false; // Changes when the character is on the ground
    private Rigidbody2D _controller; // The character controller
    private Vector3 _velocity; // Velocity of the player

    // Start is called before the first frame update
    void Start()
    {

        _controller = GetComponent<Rigidbody2D>(); // Gets the game object's character controller script

    }

    // Update is called once per frame
    void Update()
    {

        Movement(); // Movement method

    }

    private void Movement()
    {

        // Checks if the player  is standing on the ground
        _isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundDistance, groundMask);

        // If the character is on the ground the velocity.y is set to -2f (could be 0 but -2f ensures the character is smoothly stuck to the ground)
        if (_isGrounded && _velocity.y < 0)
        {
            _velocity.y = -2f;
        }

        // Gets the X and Z (WASD or arrow keys) movement
        // ? operator (will explain)
        // If canMove is false then the values are 0
        float x = canMove ? Input.GetAxis("Horizontal") : 0f;

        // The move vector relative to the player's position
        Vector3 move = transform.right * x;

        // Moves the player relative to the game time
        _controller.MovePosition(move * walkSpeed * Time.deltaTime);

        // Sets the velocity of the Y to give enough speed to reach the jump height
        // Vy = -2Hg (where H is jumpHeight and g is gravity)
        // Don't have to worry about the math
        // Only works if you are grounded
        if (Input.GetButtonDown("Jump") && _isGrounded)
        {
            _velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
        }

        // Applies gravity to the character
        _velocity.y += gravity * Time.deltaTime;
        // Moves the character by the gravity
        _controller.velocity = (_velocity * Time.deltaTime);

    }

}


