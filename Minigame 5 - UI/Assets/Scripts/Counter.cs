using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text winner;
    public Text loser;
    private int score;
    private int badscore;

    public GameObject heart;

    // Start is called before the first frame update
    void Start()
    {
        winner.text = "";
        loser.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        winner.text = "" + score;
        loser.text = "" + badscore;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.tag == "potion")
            {
            score = score + 1;
        }


        if (collision.gameObject.tag == "heart")
        {
            badscore = badscore + 1;
        }


    }
}
