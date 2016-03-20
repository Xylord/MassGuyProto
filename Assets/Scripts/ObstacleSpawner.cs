using UnityEngine;
using System.Collections;



public class ObstacleSpawner : MonoBehaviour {

    public Transform[] SpawnPointsPiston, SpawnPointsFrame, SpawnPointsHeart;
    public float spawnTime;
    public float beginPlay;
    public static float speedFactor = 0.2f;
    public GameObject[] ObjectsToSpawn;
    public GameObject BottleSection;
    public static Vector3 spawnPos;
    float totTime = 0;
    
    // Use this for initialization
    void Start () {
        //SpawnObstacle();
        //InvokeRepeating("SpawnObstacle", beginPlay, MassGuy.basicMass / MassGuy.mass);
        spawnPos = transform.position;
    }
	
	// Update is called once per frame
	void Update ()
    {
        spawnTime = MassGuy.basicMass / MassGuy.mass;

        totTime += Time.deltaTime;

        if (totTime > spawnTime)
        {
            SpawnObstacle();
            totTime = 0;

        }

    }

    /*IEnumerator SpawnObstacle()
    {
        print("shit");
        int spawnIndex = Random.Range(0, SpawnPoints.Length);
        int objectIndex = Random.Range(0, ObjectsToSpawn.Length);
        Instantiate(ObjectsToSpawn[objectIndex], SpawnPoints[spawnIndex].position, SpawnPoints[spawnIndex].rotation);
        yield return new WaitForSeconds(Time.deltaTime * 100000 * MassGuy.basicMass / MassGuy.mass);
    }*/

    void SpawnObstacle()
    {
        int objectIndex = Random.Range(0, ObjectsToSpawn.Length);


        if (ObjectsToSpawn[objectIndex].CompareTag("Piston"))
        {
            int spawnIndex = Random.Range(0, SpawnPointsPiston.Length);
            Instantiate(ObjectsToSpawn[objectIndex], SpawnPointsPiston[spawnIndex].position, SpawnPointsPiston[spawnIndex].rotation);
        }
       
        else if (ObjectsToSpawn[objectIndex].CompareTag("Frame"))
        {
            int spawnIndex = Random.Range(0, SpawnPointsFrame.Length);
            Instantiate(ObjectsToSpawn[objectIndex], SpawnPointsFrame[spawnIndex].position, SpawnPointsFrame[spawnIndex].rotation);
        }

        else if (ObjectsToSpawn[objectIndex].CompareTag("Heart"))
        {
            int spawnIndex = Random.Range(0, SpawnPointsHeart.Length);
            Instantiate(ObjectsToSpawn[objectIndex], SpawnPointsHeart[spawnIndex].position, SpawnPointsHeart[spawnIndex].rotation);
        }
        
        //Instantiate(BottleSection, transform.position, Quaternion.Euler(90, 0, 0));
        
    }

    public void RespawnObject(GameObject respawnedObject)
    {
        if (respawnedObject.CompareTag("Piston"))
        {
            int spawnIndex = Random.Range(0, SpawnPointsPiston.Length);
            Vector3 pos = SpawnPointsPiston[spawnIndex].position;
            Quaternion rot = SpawnPointsPiston[spawnIndex].rotation;
            respawnedObject.transform.position = pos;
            respawnedObject.transform.rotation = rot;
        }

        else if (respawnedObject.CompareTag("Frame"))
        {
            int spawnIndex = Random.Range(0, SpawnPointsFrame.Length);
            Vector3 pos = SpawnPointsFrame[spawnIndex].position;
            Quaternion rot = SpawnPointsFrame[spawnIndex].rotation;
            respawnedObject.transform.position = pos;
            respawnedObject.transform.rotation = rot;
        }

        else if (respawnedObject.CompareTag("Heart"))
        {
            int spawnIndex = Random.Range(0, SpawnPointsHeart.Length);
            Vector3 pos = SpawnPointsHeart[spawnIndex].position;
            Quaternion rot = SpawnPointsHeart[spawnIndex].rotation;
            respawnedObject.transform.position = pos;
            respawnedObject.transform.rotation = rot;
        }
    }
}
