using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class TextFade : MonoBehaviour
{
    private Text text;
    private Outline outline;

    void Start()
    {
        text = GetComponent<Text> ();
        outline = GetComponent<Outline> ();
    }

    private void Update()
    {
        text.color = new Color(text.color.r, text.color.g, text.color.b, Mathf.PingPong(Time.time, 0.8f)+0.3f);
        outline.effectColor = new Color(outline.effectColor.r, outline.effectColor.g, outline.effectColor.b);
    }

}
