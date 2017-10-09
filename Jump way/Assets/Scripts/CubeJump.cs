using UnityEngine;
using System.Collections;

public class CubeJump : MonoBehaviour {

    public GameObject mainCube;

	void OnMouseDown () {
        mainCube.transform.position = new Vector3(mainCube.transform.position.x, mainCube.transform.position.y+0.5f, mainCube.transform.position.z);
	}
	
	void OnMouseUp() {
	
	}
}
