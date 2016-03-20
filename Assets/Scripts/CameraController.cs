using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public float speed;
    public Vector3 circleCenter;
    public float areaRadius;

	// Use this for initialization
	void Start () {
    //    circleCenter = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        /*Vector3 movement = Vector3.zero;

        if (Input.GetKey(KeyCode.RightArrow))// && transform.position.x < areaLimits)
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

        Vector3 offset = transform.position - circleCenter;
        if (offset.magnitude > areaRadius)
        {
            offset.Normalize();
            offset = offset * areaRadius;
            print("The offset is" + offset.x + " " + offset.y + " " + offset.z);
            transform.position = offset;
        }*/
    }
}
