using UnityEngine;
using System.Collections;

public class FallingObstacle : MonoBehaviour {

    public bool isBreakable;
    public float timeSinceBegin = 0;

    // Use this for initialization
    void Start () {
        
	}           
	
	// Update is called once per frame
	void Update () {
        float fallingSpeed = ObstacleSpawner.speedFactor * MassGuy.mass / MassGuy.basicMass;

        transform.Translate(0, fallingSpeed, 0);
        //timeSinceBegin += Time.deltaTime;
        //if (timeSinceBegin > 15) Destroy(this.gameObject);

    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.gameObject.name == "EndZone")
        {
            Destroy(this.gameObject);
        }
        
        if(collision.collider.gameObject.name == "Player")
        {
                bool isBreakingSpeed = MassGuy.breakingSpeed;
                if (isBreakingSpeed && isBreakable) Destroy(this.gameObject);
                else Destroy(collision.collider.gameObject);
        }
    }

}
