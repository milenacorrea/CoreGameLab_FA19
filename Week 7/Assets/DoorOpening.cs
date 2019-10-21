using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class DoorOpening : MonoBehaviour
{
    bool normal;
    bool open;
        bool close;
    // Start is called before the first frame update
    void Start()
    {
        normal = true;
        open = false;
        close = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (open == true)
        {

        }

        if (close == true)
        {

        }

    }

    public void on private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag = "entry")
        {
            open = true;
            normal = false
        }
    }
}

