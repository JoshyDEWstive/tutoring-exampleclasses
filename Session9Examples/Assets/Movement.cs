using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    // Setting the speed at which we will walk and jump
    public float walkSpeed = 1;
    public float jumpHeight = 1;

    private Vector3 _velocity;

    private Rigidbody2D _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {

        // Getting our movement axis and multiplying it by (1,0,0)
        Vector2 movement = Input.GetAxis("Horizontal") * Vector2.right * walkSpeed * Time.deltaTime;
        // Moves the character to our position plus the amount we want to move by
           
        //will do jumping friday
        if(Input.GetButtonDown("Jump")) {
            movement.y = Mathf.Sqrt(jumpHeight * 2 * _rigidbody.gravityScale); 
        }

        _rigidbody.velocity = movement;
    }


}
