using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypingText : MonoBehaviour
{
    public Text text;
    [Multiline(5)] public string textToType;
    public float delay = 1.0f;
    public float commaPause = 0.1f;
    public float stopPause = 0.1f;

    private void Start()
    {
        StartCoroutine(TypeText());

    }

    IEnumerator TypeText()
    {
        foreach (char c in textToType)
        {
            text.text += c;
            if (c == ',')
            {
                yield return new WaitForSeconds(commaPause);
            }
            else if (c == '.')
            {
                yield return new WaitForSeconds(stopPause);
            }
            else
            {
                yield return new WaitForSeconds(delay);
            }
        }
    }
}
