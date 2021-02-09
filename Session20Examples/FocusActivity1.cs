using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusActivity1 : MonoBehaviour
{

    // Bottomleft corner of the screen
    public Vector3 bottomLeft;
    public Vector3 topRight;

    public GameObject treePrefab;
    public int treesToSpawn = 3;

    private List<GameObject> trees;

    
    // Start is called before the first frame update
    void Start()
    {
        trees = new List<GameObject>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyUp(KeyCode.E)) {

            foreach(GameObject go in trees) {
                Destroy(go);
            }
            treesToSpawn = Random.Range(3, 10);

            trees.Clear();
            Vector3 myPosition = transform.position;

            float xSize = topRight.x - bottomLeft.x;
            float ySize = topRight.z - bottomLeft.z;

            for (int i = 0; i < treesToSpawn; i++) {

                GameObject tree = Instantiate(treePrefab);

                float yValue = (bottomLeft.y + topRight.y) / 2;

                float xPos = Random.Range(0, xSize) + bottomLeft.x;
                float yPos = Random.Range(0, ySize) + bottomLeft.z;

                tree.transform.position = new Vector3(xPos, yValue, yPos);

                trees.Add(tree);
            }

        }

    }

}
