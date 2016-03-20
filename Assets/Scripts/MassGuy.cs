using UnityEngine;
using System.Collections;

public class MassGuy : MonoBehaviour {

    public float speed = 100;
    public static float basicMass = 10;
    public float maxMass;
    public static float areaRadius = 19;
    public float maxHeight;
    public static float mass;
    public static bool breakingSpeed;
    public bool notifyHit;


    // Use this for initialization
    void Start () {
        mass = basicMass;
        breakingSpeed = false;
     }
	
	// Update is called once per frame
	void Update () {
        float massDelta = maxMass - mass;
        float maxMassDelta = maxMass - basicMass + 0.5f;
        float massFactor = (maxMassDelta - massDelta) / maxMassDelta;

        Vector3 movement = Vector3.zero;

	    if(Input.GetKey(KeyCode.RightArrow))// && transform.position.x < areaLimits)
        {
            movement += Vector3.right;
        }
        if (Input.GetKey(KeyCode.LeftArrow))// && transform.position.x > -areaLimits)
        {
            movement += Vector3.left;
        }
        if (Input.GetKey(KeyCode.UpArrow))// && transform.position.z < areaLimits)
        {
            movement += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.DownArrow))// && transform.position.z > -areaLimits)
        {
            movement += Vector3.back;
        }

        //transform.Rotate(movement);
        transform.Translate(movement.normalized * speed * Time.deltaTime);

        Vector3 offset = transform.position;
        if (offset.magnitude > areaRadius)
        {
            offset.Normalize();
            offset = offset * areaRadius;
            transform.position = offset;
        }

        //Mass effects
        if (Input.GetKey(KeyCode.Mouse0))
        {
            float mouseMotion = Input.GetAxis("Mouse Y");

            if (mouseMotion > 0.5) mouseMotion = 0.5f;
            else if (mouseMotion < -0.5f) mouseMotion = -0.5f;

            if (mass < maxMass && mouseMotion > 0)
            {
                mass += 0.05f * maxMassDelta * mouseMotion;
            }
            
            else if (mass > basicMass && mouseMotion < 0)
            {
                mass += 0.05f * maxMassDelta * mouseMotion;
            }
        }

        if (massFactor > 0.75f) breakingSpeed = true;
        else breakingSpeed = false;

        Vector3 pos = transform.position;
        pos.y = maxHeight * mass / basicMass / 2 - maxHeight;
        transform.position = pos;

        if (mass < basicMass) mass = basicMass;
        
        if (mass > maxMass) mass = maxMass;

        transform.localScale = new Vector3(1, massFactor + 1.0f, 1);
        
    }

    void OnCollisionEnter(Collision collision)
    {
        //if  (collsion.)
    }

    public static float GetMass()
    {
        return mass;
    }
}
