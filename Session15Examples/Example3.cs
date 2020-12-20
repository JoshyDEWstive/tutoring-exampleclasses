using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example3 : MonoBehaviour
{

    public Material testMaterialOne;
    public Material testMaterialTwo;

    public GameObject testGameObject;

    // Start is called before the first frame update
    void Start()
    {

        ////////////////////////////////////////////////////////////////////
        // Changing the material of an object

        // Duplicate the test object for demonstration purposes
        GameObject newGameObject = Instantiate(testGameObject);

        // Setting the objects name
        newGameObject.name = "Test Object 2";

        // Getting the mesh renderer component which contains the object's materials
        MeshRenderer meshRenderer = newGameObject.GetComponent<MeshRenderer>();
        
        // The main material of the object, we are changing it to test material two
        meshRenderer.material = testMaterialTwo;

        // Changing the game object's position
        newGameObject.transform.position = new Vector3(3, 0, 0);

        ////////////////////////////////////////////////////////////////////
        // Modifying the values of a material of an object

        // Duplicate the test object for demonstration purposes
        GameObject newGameObject2 = Instantiate(testGameObject);

        // Setting the objects name
        newGameObject2.name = "Test Object 3";

        // Getting the mesh renderer component which contains the object's materials
        MeshRenderer meshRenderer2 = newGameObject2.GetComponent<MeshRenderer>();

        // Creating a new material based on the old material's properties.
        Material newMaterial = new Material(testMaterialTwo);
        
        // Changing the colour of the material
        newMaterial.color = new Color(0.6f, 0.3f, 0f);

        // Changing the material of the renderer to be our new material
        meshRenderer2.material = newMaterial;

        // Changing the game objects position
        newGameObject2.transform.position = new Vector3(6, 0, 0);

    }

}
