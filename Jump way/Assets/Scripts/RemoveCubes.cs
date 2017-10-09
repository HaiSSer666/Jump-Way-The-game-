using UnityEngine;
using System.Collections;

public class RemoveCubes : MonoBehaviour {

	void Start ()
    {
        Destroy(gameObject, 1.0f);
	}
	

	void Update ()
    {
        transform.position -= new Vector3(0, 0.2f, 0);
	}
}
