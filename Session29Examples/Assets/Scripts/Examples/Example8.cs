using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example8 : MonoBehaviour
{

    ////////////////////////////////////////////////////////////
    // Example 8
    // 
    // Using randomness with percentages

    // Percentages are in between 0-100% (for randomness)

    // Add slider bar to the Unity Editor for ease of access
    [Range(0,1)]
    public float redChance = 0.5f; // 50% chance
    public float greenChance = 0.25f; // 25% chance


    // The first way to do this
    void PercentageOne() {

        float randomNumber = Random.Range(0, 1f);

        float modifier = 1 - redChance;

        if(randomNumber >= modifier) {

            Debug.Log("Red");

        }

    }

    // Second way
    // Slightly simpler
    void PercentageTwo() {

        float randomNumber = Random.Range(0, 1f);

        if(randomNumber <= greenChance) {

            Debug.Log("Green");

        }

    }
}
