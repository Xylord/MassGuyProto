using UnityEngine;
using System.Collections;

public class PistonScript : MonoBehaviour {

    public bool isBreakable;
    public float timeSinceBegin = 0;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        float fallingSpeed = ObstacleSpawner.speedFactor * MassGuy.mass / MassGuy.basicMass;

        //transform.Translate(0, 0, -fallingSpeed);
        Vector3 pos = transform.localPosition;
        pos.z += 2 * Mathf.Sin(5 * timeSinceBegin);
        pos.y += fallingSpeed;//BAD HARDCODERS
        transform.position = pos;

        //timeSinceBegin += Time.deltaTime;
        //if (timeSinceBegin > 15) Destroy(this.gameObject);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.name == "EndZone")
        {
            //Destroy(this.gameObject);
            //print("Destroyed?");
            ObstacleSpawner ObsSpwn = GameObject.FindObjectOfType(typeof(ObstacleSpawner)) as ObstacleSpawner;
            ObsSpwn.RespawnObject(this.gameObject);
        }
        if (collision.collider.gameObject.name == "Player")
        {
            bool isBreakingSpeed = MassGuy.breakingSpeed;
            if (isBreakingSpeed && isBreakable) Destroy(this.gameObject);
            else
            {
                Destroy(collision.collider.gameObject);
                print("GameOver");
            }
        }
    }
}
