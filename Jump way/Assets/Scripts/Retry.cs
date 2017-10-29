using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Retry : MonoBehaviour {

    public GameObject cube;
    public GameObject[] hideObjects;
    public GameObject[] showObjects;
    public Text gameOver;

    void Update ()
    {
        if(cube.transform.localPosition.y < -15)
        {
            //showObject.GetComponent<Renderer>().enabled = true;
            //Destroy(cube);
            cube.transform.localPosition = new Vector3(-1.5f, -15.0f, -15.0f);
            gameOver.text = "Game Over";

            foreach (GameObject go in hideObjects)
            {
                go.SetActive(false);
            }
            foreach (GameObject go in showObjects)
            {
                go.GetComponent<Renderer>().enabled = true;
            }
        }
	}
	
}
