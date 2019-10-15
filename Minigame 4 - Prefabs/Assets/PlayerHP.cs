using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public Text health;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        health.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        health.text = "" + score;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            score = score + 1;
        }
    }
}
