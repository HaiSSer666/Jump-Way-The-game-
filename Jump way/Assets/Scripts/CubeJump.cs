using UnityEngine;
using System.Collections;

public class CubeJump : MonoBehaviour {
    public GameObject mainCube;
    private bool animate;
    private float compressSpeed = 1.0f;
    private float startTime;

    private void FixedUpdate ()
    {
        if (animate && mainCube.transform.localScale.y > 0.5f)
        {
            pressCube(compressSpeed);
        }
        else if (!animate)
        {
            if (mainCube.transform.localScale.y < 1.0f)
            {
                pressCube(-compressSpeed * 3.0f);
            }
        }
    }

    void OnMouseDown ()
    {
        if (mainCube.GetComponent<Rigidbody>())
        {
            animate = true;
            startTime = Time.time;
        }
	}
	
	void OnMouseUp ()
    {
        if (mainCube.GetComponent<Rigidbody>())
        {
            animate = false;

            //Jump
            float force, startEndDiff;
            startEndDiff = Time.time - startTime;
            if (startEndDiff < 3.0f)
            {
                force = 150 * startEndDiff;
            }
            else
            {
                force = 300.0f;
            }
            if (force < 100.0f)
            {
                force = 100.0f;
            }

            mainCube.GetComponent<Rigidbody>().AddRelativeForce(mainCube.transform.up * force);
            mainCube.GetComponent<Rigidbody>().AddRelativeForce(mainCube.transform.right * -force);
        }
    }

    void pressCube (float force)
    {
        mainCube.transform.localPosition -= new Vector3(0.0f, force * Time.deltaTime, 0.0f);
        mainCube.transform.localScale -= new Vector3(0.0f, force * Time.deltaTime, 0.0f);
    }
}
