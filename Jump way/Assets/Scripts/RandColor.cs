using UnityEngine;
using System.Collections;

public class RandColor : MonoBehaviour {

    public Color[] colors;

    /*public Color GetColor(int i)
    {
        return colors[i];
    }*/

    void Start () {
        GetComponent<MeshRenderer>().material.color = colors[Random.Range(0, colors.Length)];
	}

}
