using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameArrangement : MonoBehaviour {
    public Text playButtonTxt;
    public Text headline;
    public GameObject mainCube, cubes, lastCube, spawn_blocks;
    public GameObject[] r_cubes, buttons;


    private bool clicked;

    public void OnMouseDown()
    {
        if(!clicked)
        {
            clicked = true;

            playButtonTxt.gameObject.SetActive(false);
            headline.text = "0";

            StartCoroutine(removeButtons());

            mainCube.GetComponent<Animation>().Play("StartGame");
            cubes.GetComponent<Animation>().Play("RemoveCubes");
            

            StartCoroutine(deleteCubes());

            //lastCube.GetComponent<Animation>().Play("TransformToBlock");
        }
    }

    IEnumerator deleteCubes()
    {
        spawn_blocks.GetComponent<SpawnBlocks>().enabled = true;
        for (int i = 0; i < 3; i++)
        {
            if (i == 2)
            {
                lastCube.GetComponent<Animation>().Play("TransformToBlock");
            }
            r_cubes[i].GetComponent<RemoveCubes>().enabled = true;
            yield return new WaitForSeconds(1.0f);
            Destroy(r_cubes[i]);
        }
        mainCube.AddComponent<Rigidbody>();
        //spawn_blocks.GetComponent<SpawnBlocks>().enabled = true;
    }

    IEnumerator removeButtons()
    {
        yield return new WaitForSeconds(0.0f);
        foreach (GameObject button in buttons)
        {
            button.GetComponent<Scroll>().speed = -4f;
            button.GetComponent<Scroll>().pos = -150f;
        }
    }
}
