using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example5 : MonoBehaviour
{

    public GameObject prefabToSpawn;
    public List<GameObject> listOfBeans;
    public GameObject parentObject;

    [Range(0f,1f)]
    public float speed = 0.25f;

    // Start is called before the first frame update
    void Start()
    {

        listOfBeans = new List<GameObject>();

        parentObject = new GameObject("Waves");

        int number = 0;
        while (number < 50)
        {

            // Spawn our object

            GameObject objectInLine = Instantiate(prefabToSpawn);

            objectInLine.transform.parent = parentObject.transform;

            // In this case sin will be between 0 and 1, you may want to use this to change your colour!
            float sinValue = Mathf.Sin(number);

            objectInLine.transform.position = new Vector3(number * 2, 2 * sinValue, 0);

            MeshRenderer meshRenderer = objectInLine.GetComponent<MeshRenderer>();

            Material oldMaterial = meshRenderer.material;
            Material newMaterial = new Material(oldMaterial);

            newMaterial.color = new Color(1f * sinValue, 0.3f, 0f);

            meshRenderer.material = newMaterial;

            listOfBeans.Add(objectInLine);
            // Update the condition
            number += 1;

        }

    }

    bool waiting = false;
    int iterations = 0;
    // Update is called once per frame
    void Update()
    {

        if (waiting == false) StartCoroutine(updateBeans());
    }

    IEnumerator updateBeans()
    {
        waiting = true;
        int number = 0;
        while (number < 50)
        {

            // Spawn our object

            GameObject objectInLine = listOfBeans[number];

            objectInLine.transform.parent = parentObject.transform;

            // In this case sin will be between 0 and 1, you may want to use this to change your colour!
            float sinValue = Mathf.Sin(number + iterations);

            objectInLine.transform.position = new Vector3(number * 2, 2 * sinValue, 0);

            /*MeshRenderer meshRenderer = objectInLine.GetComponent<MeshRenderer>();

            Material newMaterial = meshRenderer.material;

            newMaterial.color = new Color(1f * sinValue, 0.3f, 0f);

            meshRenderer.material = newMaterial;*/

            // Update the condition
            number += 1;

        }

        iterations += 1;
        yield return new WaitForSeconds(speed);
        waiting = false;
    }
}
