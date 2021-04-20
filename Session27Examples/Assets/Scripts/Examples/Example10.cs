using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Random.InitState(23234232);
        Debug.Log(Mathf.PerlinNoise(0.5f, 0.6f));
        Debug.Log(Mathf.PerlinNoise(0.4f, 0.1f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
