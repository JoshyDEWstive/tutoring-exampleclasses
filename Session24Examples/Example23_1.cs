using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example23_1 : MonoBehaviour
{

    ///////////////////////////////////////////////////////////
    // Perlin Noise and 2D Grid Worlds

    // Many worlds in games are based on a 2D grid.
    // Each 'cell' on the world is represented by its x and y value
    // These 'cells' contain the data about it like what colour it is, how high it is et cetera.

    // Generating a flat plane of cubes

    public float scale = 1;
    public Vector2 offset = new Vector2(0, 0);

    public void GenerateCubes()
    {

        // Setting how big the plane is going to be
        int xSize = 10; // How wide
        int ySize = 10; // How long

        // It is a 2D plane so we loop through X and Y 
        for (int x = 0; x < xSize; x++)
        {
            for (int y = 0; y < ySize; y++)
            {

                // Note:
                // You can spawn primitives by using GameObject.CreatePrimitive
                // PrimitiveType.Cube;
                // PrimitiveType.Capsule;
                // PrimitiveType.Cylinder;

                // Instantiating a new primitive in the world
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

                // Change the position based what cell we are on
                cube.transform.position= new Vector3(x, 0, y);

                // Changing the name of the cuve
                cube.name = "Cube (" + x + "," + y + ")";
            }
        }

    }

    public void GenerateCubesPerlin()
    {

        // Setting how big the plane is going to be
        int xSize = 25; // How wide
        int ySize = 25; // How long

        // It is a 2D plane so we loop through X and Y 
        for (int x = 0; x < xSize; x++)
        {
            for (int y = 0; y < ySize; y++)
            {

                // Note:
                // You can spawn primitives by using GameObject.CreatePrimitive
                // PrimitiveType.Cube;
                // PrimitiveType.Capsule;
                // PrimitiveType.Cylinder;

                // Instantiating a new primitive in the world
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

                // Get perlin noise value to determine position
                float xNoise = (offset.x + x) / xSize * scale + 0.01f;
                float yNoise = (offset.y + y) / ySize * scale + 0.01f;
                float perlinNoise = Mathf.PerlinNoise(xNoise, yNoise); // Ensure that X and Y values are between 0 and 1

                float height = 0; // Change the height of the cubes based on where they are
                if (perlinNoise <= 0.25f) height = 0;
                else if (perlinNoise <= 0.40f) height = 1;
                else if (perlinNoise <= 0.6f) height = 2;
                else if (perlinNoise <= 1f) height = 3;

                // Change the position based what cell we are on
                cube.transform.position = new Vector3(x, height, y);

                // Changing the name of the cuve
                cube.name = "Cube (" + x + "," + y + ")";
            }
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        GenerateCubesPerlin();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
