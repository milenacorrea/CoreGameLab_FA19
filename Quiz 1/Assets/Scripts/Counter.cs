using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text counter;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        counter.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        counter.text = "" + score;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        score = score + 1;
    }
}
