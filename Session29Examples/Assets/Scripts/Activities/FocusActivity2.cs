using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusActivity2 : MonoBehaviour
{

    // FOCUS ACTIVITY 2
    // Making a world with perlin noise

    // Variables 

    // Perlin Noise requires an X and Y value and a position in the world to affect, so therefore we can assume
    // that we need to know how big the world actually is
    // We can use int or vectors here

    [SerializeField] // Use this to see private variables in the inspector, it is mainly used for saving and this is not its intended purpose
    private int widthSize;
    [SerializeField]
    private int heightSize;

    // We need to have variables for our two modifiers
    // Scale
    // Offset (we need both an X and a Y value)
    // It is important to note that we can use Vectors here as well

    public float scale;

    // Offsets
    public float offsetX;
    public float offsetY;

    // World data
    // This is a 2D array, it means that it takes both an X and a Y value to get the result
    private GameObject[,] worldData;

    public void Start() {
        // Before we start generating our heights and our world, we need a terrain to work on

        // Generate our basic terrain
        GenerateTerrain();

    }

    // Generate the terrain with height
    public void GenerateTerrain() {

        // Initialise our array because if it is not initialised it doesn't know how big it is
        worldData = new GameObject[widthSize, heightSize];

        // We need to loop through all the blocks in the world

        // These loops loop through each block in the world
        for (int x = 0; x < widthSize; x++) {
            for (int y = 0; y < heightSize; y++) {

                // Generate our perlin noise
                // Order of operations for perlin noise

                // 1. Find our offsets (DONE)
                // 2. Find our x and y coordinate (DONE)
                // 3. Generate the perlin noise (DONE)
                // 4. Apply our scale

                // The values we use for the coordinates must be in between 0 and 1
                float perlinX = ((float) x) / widthSize + offsetX;
                float perlinY = ((float) y ) / heightSize + offsetY;

                // The function is always going to return a float value in between 0 and 1
                float perlinNoise = Mathf.PerlinNoise(perlinX, perlinY);

                // Applying our scale
                perlinNoise = perlinNoise * scale;

                // Apply our noise to find the heights
                float height = 0; // Default height

                // If statement method
                Debug.Log(perlinNoise);
                // Remember that we start from the lower value to the highest
                if (perlinNoise < 0.2f) height = 0;
                else if (perlinNoise < 0.4f) height = 1;
                else if (perlinNoise < 0.6f) height = 2;
                else if (perlinNoise < 0.8f) height = 3;
                else if (perlinNoise < 1f) height = 4;

                // Now we know the position of each tile (block) now we need to spawn the blocks

                // We need to instantiate the world! (just cubes)
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

                // We need to move the cubes
                // Y value is going to be Z in the Vector3 because we are converting it to a X,Z plane

                cube.transform.position = new Vector3(x, height, y);

                // Add the cubes to the array

                worldData[x, y] = cube;

            }
        }

    }

}
