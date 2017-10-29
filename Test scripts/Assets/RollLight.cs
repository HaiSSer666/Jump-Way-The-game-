using UnityEngine;
using System.Collections;

public class RollLight : MonoBehaviour {

    //Light light;
    public int speed = 1;
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.Rotate(Vector3.right * Time.deltaTime * speed);
        transform.Rotate(Vector3.up * Time.deltaTime * speed, Space.World);
    }
}
