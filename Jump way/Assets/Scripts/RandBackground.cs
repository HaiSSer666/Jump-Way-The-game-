using UnityEngine;
using System.Collections;

public class RandBackground : MonoBehaviour {

    public Material[] materials;

	void Start () {
        GetComponent<Skybox>().material = materials[Random.Range(0, materials.Length)];
	}

}
