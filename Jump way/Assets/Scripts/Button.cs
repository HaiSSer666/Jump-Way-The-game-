using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Button : MonoBehaviour
{

    public float growUp, growDown;

    void OnMouseDown()
    {
        transform.localScale = new Vector3(growUp, growUp, growUp);
    }

    void OnMouseUp()
    {
        transform.localScale = new Vector3(growDown, growDown, growDown);
    }

    private void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case "Retry":
            SceneManager.LoadScene("Main");
            break;
            case "Contact":
                Application.OpenURL("https://vk.com/id11498513");
            break;
        }
    }
}
