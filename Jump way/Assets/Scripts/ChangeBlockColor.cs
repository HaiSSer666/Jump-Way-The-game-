using UnityEngine;
using System.Collections;

public class ChangeBlockColor : MonoBehaviour {

    //RandColor rc = new RandColor();

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Cube")
        {
            collision.gameObject.GetComponent<MeshRenderer>().material.color = GetComponent<MeshRenderer>().material.color; //rc.colors[Random.Range(0, rc.colors.Length)];
        }
    }

}
