using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogSpawner : MonoBehaviour
{

    public GameObject logPrefab; // Our log prefab
    public Transform spawnPoint; // Where our log will be spawned
    public float spawnInterval; // How long between each spawn
    public bool spawnLogs = true; // Are we currently spawning logs?

    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = GameObject.FindGameObjectWithTag("LogSpawn").transform;

        StartCoroutine(LogSpawning());
    }

    // Note that all this could be optimised to run better, and we can talk about that later
    IEnumerator LogSpawning() {

        while(true) {

            // Logs should only spawn when spawnLogs is true
            if(spawnLogs) {
                // We are creating a new log prefab in the game world, we are setting its position to the spawnpoint
                // and we are using the default rotation.
                GameObject newLog = Instantiate(logPrefab);
                newLog.transform.position = spawnPoint.transform.position;
                newLog.name = "Log";
            }

            yield return new WaitForSeconds(spawnInterval);
        }

    }

}
