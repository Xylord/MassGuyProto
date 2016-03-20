using UnityEngine;
using System.Collections;

public class BottleMotion : MonoBehaviour
{

    public float timeSinceBegin = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float fallingSpeed = ObstacleSpawner.speedFactor * MassGuy.mass / MassGuy.basicMass;

        transform.Translate(0, 0, -fallingSpeed);

        //timeSinceBegin += Time.deltaTime;
        //if (timeSinceBegin > 30) Destroy(this.gameObject);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.name == "EndZone")
        {
            //Destroy(this.gameObject);
            Vector3 pos = ObstacleSpawner.spawnPos;
            this.gameObject.transform.position = pos;
        }
    }
}