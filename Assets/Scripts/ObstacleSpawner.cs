using UnityEngine;
using System.Collections;



public class ObstacleSpawner : MonoBehaviour {

    public GameObject object1;
    
    // Use this for initialization
    void Start () {
        object1 = GetComponent<GameObject>();
        Instantiate(object1, transform.position + new Vector3(0, 5, 0), transform.rotation);
    }
	
	// Update is called once per frame
	void Update ()
    {
        float fallingSpeed = MassGuy.mass;

        
	}

    void SpawnObstacle(GameObject obstacle)
    {

    }
}
