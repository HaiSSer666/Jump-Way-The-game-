using UnityEngine;
using System.Collections;

public class CubeJump : MonoBehaviour {
    public GameObject mainCube;
    private bool animate;
    private float compressSpeed = 1.0f;

    private void FixedUpdate()
    {
        if(animate && mainCube.transform.localScale.y > 0.5f)
        {
            pressCube(compressSpeed);
            //mainCube.transform.localPosition -= new Vector3(0.0f, compressSpeed * Time.deltaTime, 0.0f);
            //mainCube.transform.localScale -= new Vector3(0.0f, compressSpeed * Time.deltaTime, 0.0f);
        }
        else if (!animate)
        {
            if(mainCube.transform.localScale.y < 1.0f)
            {
                pressCube(-compressSpeed * 3.0f);
                //mainCube.transform.localPosition += new Vector3(0.0f, compressSpeed * Time.deltaTime * 5.0f, 0.0f);
                //mainCube.transform.localScale += new Vector3(0.0f, compressSpeed * Time.deltaTime * 5.0f, 0.0f);
            }
            /*else if(mainCube.transform.localScale.y != 1.0f)
            {
                mainCube.transform.localScale += new Vector3(1.0f, 1.0f, 1.0f);
            }*/
        }
    }

    void OnMouseDown ()
    {
        if (mainCube.GetComponent<Rigidbody>())
        {
            animate = true;
        }
        //mainCube.transform.position = new Vector3(mainCube.transform.position.x, mainCube.transform.position.y+0.5f, mainCube.transform.position.z);
	}
	
	void OnMouseUp()
    {
        if (mainCube.GetComponent<Rigidbody>())
        {
            animate = false;
        }
    }

    void pressCube(float force)
    {
        mainCube.transform.localPosition -= new Vector3(0.0f, force * Time.deltaTime, 0.0f);
        mainCube.transform.localScale -= new Vector3(0.0f, force * Time.deltaTime, 0.0f);
    }
}
