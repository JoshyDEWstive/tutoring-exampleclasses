using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example9 : MonoBehaviour
{

    // Session 22
    // Perlin Noise & Animations


    public Animator animator;
    public bool bounce;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(bounce == true) {
            // Bounce the cube once

            // Triggers the trigger "Bounce" on the animator
            animator.SetTrigger("Bounce");

            // Using bools with the animator
            animator.SetBool("BounceBool", false);

            
            bounce = false;

        }   
        
    }

    
}
