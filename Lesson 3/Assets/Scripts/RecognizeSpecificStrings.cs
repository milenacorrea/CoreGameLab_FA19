﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecognizeSpecificStrings : MonoBehaviour
{
    List<string> letters = new List<string>();
    string[] mywords = new string[]
    {
        "BEANS", "CHICKEN", "EGGS", "CHEESE", "TOMATO"
    };
    string myword;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        myword = mywords[Random.Range(0, mywords.Length - 1)];
        text.text = myword;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnGUI()
    {
        if (Event.current.type == EventType.KeyDown && Event.current.keyCode != KeyCode.None)
        {
            Debug.Log("Current detected event: " + Event.current);
            letters.Add(Event.current.keyCode.ToString());

            for (int i = 0; i <= letters.Count; i++)
            {
                if (letters[i] == myword.Substring(i, 1))
                {
                    Debug.Log("yay you typing");
                    text.color = Color.green;

                    if (letters.Count == myword.Length)
                    {
                        Debug.Log("you typed" + myword + "yay you are a typer woohoo");
                        letters.Clear();
                        myword = mywords[Random.Range(0, mywords.Length - 1)];
                        text.text = myword;
                        text.color = Color.white;
                    }
                }
                else
                {
                    Debug.Log("boo you suck");
                    letters.Clear();
                    text.color = Color.red;
                }


              //  foreach (string letter in letters)
              //  {
              //      Debug.Log(letter);
              //  }
            }
        }
    }
}
// have a word..
// did a key get pressed?
    // was the key the first letter?
// if yes yay!
    // is another key pressed?
    // yay second letters!
// if no :(