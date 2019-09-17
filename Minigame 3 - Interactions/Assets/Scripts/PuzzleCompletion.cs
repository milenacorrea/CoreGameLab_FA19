using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleCompletion : MonoBehaviour
{
    public Text winner;
    private bool complete = false;

    // Start is called before the first frame update
    void Start()
    {
        complete = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Changes color of platforms to symbolize completeion level of puzzle

        if (collision.gameObject.tag == "8" )
        {
            collision.gameObject.GetComponent<SpriteRenderer>().color = Color.green;
        }
        if (collision.gameObject.tag == "1")
        {
            collision.gameObject.GetComponent<SpriteRenderer>().color = Color.green;
        }
        if (collision.gameObject.tag == "6")
        {
            collision.gameObject.GetComponent<SpriteRenderer>().color = Color.green;
        }
        if (collision.gameObject.tag == "4")
        {
            collision.gameObject.GetComponent<SpriteRenderer>().color = Color.green;
        }
        if (collision.gameObject.tag == "9")
        {
            collision.gameObject.GetComponent<SpriteRenderer>().color = Color.green;
        }
        if (collision.gameObject.tag == "3")
        {
            collision.gameObject.GetComponent<SpriteRenderer>().color = Color.green;
        }
        if (collision.gameObject.tag == "2")
        {
            complete = true;
            collision.gameObject.GetComponent<SpriteRenderer>().color = Color.green;
            winner.text = "Puzzle Complete!";

            //Reference for text to appear: https://stackoverflow.com/questions/42477918/unity-guitext-on-collision-c-sharp

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

