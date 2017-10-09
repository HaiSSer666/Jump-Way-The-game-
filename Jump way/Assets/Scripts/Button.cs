using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour
{

    void OnMouseDown()
    {
        transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
    }

    void OnMouseUp()
    {
        transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }
}
