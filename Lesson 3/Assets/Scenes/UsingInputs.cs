using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingInputs : MonoBehaviour
{
    float horz;
    float vert;

    Rigidbody2D rb;
    //defining that there is a rigidbody

    public float forceAmount;
    //number for the amount of force being pressed onto the rigidbody

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //acessing the rigidbody
    }

    // Update is called once per frame
    void Update()
    {
        horz = Input.GetAxisRaw("Horizontal");
        //defines what the float is pulling, it is pulling our horizontal x axis
        vert = Input.GetAxisRaw("Vertical");

        //if (Input.GetKeyDown(KeyCode.O))
        //{
        //    horz = -1f;
        //}
        //else if (Input.GetKeyDown(KeyCode.P))
        //{
        //    horz = 1f;
        //}
        //this is how to get different keys pinned

        //how to check two things at once in an if statement -> and
        if (Input.GetKey(KeyCode.G))
        {
            Debug.Log("Hitting G");
            if (Input.GetKey(KeyCode.H))
            {
                Debug.Log("Hitting G and H");
            }
        }
        else if (Input.GetKey(KeyCode.H))
        {
            Debug.Log("Hitting H");
        }
        //if fing 1
        //else if 2, 3, 4
        //else 5

        //if (Input.GetMouseButton("fire1"))
        //{
        //    When I click
        //}

        //void OnMouseDown()
        //{
        //    detects when I get clicked, clicked something specifically
        //}


        //GetKey - when button is pushed continuously, held
        //GetKeyDown - key held for one frame (i.e. rhythm games), called only once
        //GetKeyUp - when button isn't being held, stopping an action, slowing down, charging an attack


        Debug.Log(horz + " " + vert);
        //this prints out the values. So right and up are +1, down and left are -1

        //this makes it move
        //transform.Translate(horz * Time.deltaTime, vert * Time.deltaTime, 0);

        rb.AddForce(new Vector2(horz, vert));
        //this adds force to the rigidbody of our object
    }
}
