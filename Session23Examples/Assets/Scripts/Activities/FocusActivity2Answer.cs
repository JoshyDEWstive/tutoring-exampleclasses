using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusActivity2Answer : MonoBehaviour
{

    // World noise settings
    [Header("World Settings")]
    public float worldScale = 1;
    public Vector2 worldOffset = new Vector2(0, 0);

    [Header("Tree Settings")]
    public float treeScale = 1;
    public Vector2 treeOffset = new Vector2(0, 0);
    [Range(0,1)]
    public float treeMinimum = 0.3f;
    [Range(0, 1)]
    public float treeMaximum = 0.4f;

    // Setting how big the plane is going to be
    public int xSize = 25;
    public int ySize = 25;

    public GameObject treePrefab;

    [Header("Colours")]
    public Color waterColour;
    public Color sandColour;
    public Color grassColour;
    public void GenerateCubesPerlin()
    {

        GameObject worldContainer = new GameObject("World Container");

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
                float xNoise = (worldOffset.x + x) / xSize * worldScale + 0.01f;
                float yNoise = (worldOffset.y + y) / ySize * worldScale + 0.01f;
                float perlinNoise = Mathf.PerlinNoise(xNoise, yNoise); // Ensure that X and Y values are between 0 and 1

                float height = CalculateHeight(perlinNoise); // Change the height of the cubes based on where they are (look at method)
                Color colour = CalculateColour(perlinNoise); // Get the cubes colour (look at method)
                ChangeCubeColour(cube, colour); // Change the cubes colour (look at method)

                // Change the position based what cell we are on
                cube.transform.position = new Vector3(x, height, y);

                // Changing the name of the cuve
                cube.name = "Cube (" + x + "," + y + ")";
                cube.transform.SetParent(worldContainer.transform);

                // Check if you can spawn a tree

                float xTreeNoise = (treeOffset.x + x) / xSize * worldScale + 0.01f;
                float yTreeNoise = (treeOffset.y + y) / ySize * worldScale + 0.01f;
                float perlinTreeNoise = Mathf.PerlinNoise(xTreeNoise, yTreeNoise); // Ensure that X and Y values are between 0 and 1
                perlinTreeNoise *= Random.Range(0, 5);

                // Spawn a tree
                if (perlinTreeNoise > treeMinimum && perlinTreeNoise < treeMaximum && perlinNoise >= 0.4f)
                {
                    GameObject tree = Instantiate(treePrefab);
                    tree.transform.position = new Vector3(x, height + 1, y);
                }

            }
        }

    }
    // Change the height of the cubes based on where they are
    public float CalculateHeight(float perlinNoise)
    {
        float height = 0;

        if (perlinNoise <= 0.25f) height = 0;
        else if (perlinNoise <= 0.40f) height = 1;
        else if (perlinNoise <= 0.6f) height = 2;
        else if (perlinNoise <= 1f) height = 3;

        return height;
    }

    // Returns the colour based on the height
    public Color CalculateColour(float perlinNoise)
    {

        if (perlinNoise <= 0.25f) return waterColour;
        else if (perlinNoise <= 0.40f) return sandColour;
        // Greater than 0.4

        return grassColour;
    }

    // Change the colour of the cube
    public void ChangeCubeColour(GameObject cube,Color colour)
    {
        Renderer rend = cube.GetComponent<Renderer>(); // Get the cube's renderer

        Material newMaterial = new Material(rend.material);// Create a new material based off of the old material

        newMaterial.color = colour; // Change the material's colour

        rend.material = newMaterial; // Set the cubes new material
    }


    // Start is called before the first frame update
    void Start()
    {
        GenerateCubesPerlin();
    }

}
