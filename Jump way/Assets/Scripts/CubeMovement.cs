using UnityEngine;
using System.Collections;

public class CubeMovement : MonoBehaviour {
    public GameObject mainCube;
    private float movementSpeed = 1f;
    private bool start;

    void Update () {
        if (mainCube.GetComponent<Rigidbody>() && start)
        {
            mainCube.transform.localPosition -= new Vector3(0.0f, 0.0f, movementSpeed * Time.deltaTime);
        }
    }

    void OnMouseDown()
    {
            start = true;

    }
}
