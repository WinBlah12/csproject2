using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverText : MonoBehaviour//andrews code
{
    public string currentText;
    public TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {
        string[] texts = new string[] { "Nice Try", "gg try again", "you tried.", "play more war thunder lmjao", 
            "dont ragequit like a noob."};
        string currentText = texts[Random.Range(0, texts.Length)];
        Debug.Log(currentText);
        text.text = currentText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
