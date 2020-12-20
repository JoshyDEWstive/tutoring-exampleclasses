using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activities2 : MonoBehaviour
{

    ////////////////////////////////////////////////////////////////////
    // Session 15 Activity

    // Change the script that creates a wave so that the colour of the objects are different based on its height
    // Tip: colour values have to be between 0 and 1
    // Tip: Sin returns value between -0 and 1

    public GameObject prefabToSpawn;
    void Start()
    {
        SpawnObjectsInWave();
    }

    // Change this function
    public void SpawnObjectsInWave() {

        GameObject parentObject = new GameObject("Waves");

        int number = 0;
        while (number < 50) {

            // Spawn our object

            GameObject objectInLine = Instantiate(prefabToSpawn);
            objectInLine.transform.parent = parentObject.transform;
            // In this case sin will be between 0 and 1, you may want to use this to change your colour!
            float sinValue = Mathf.Sin(number);
            objectInLine.transform.position = new Vector3(number * 2,2 * sinValue,0);



            // Update the condition
            number += 1;
        }
    }


}
