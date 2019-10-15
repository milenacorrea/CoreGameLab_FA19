using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// all from unity documentation excepet the slider stuff
public class SquareMovement : MonoBehaviour
{

    public float speed;
    private Vector2 target;
    private Vector2 position;
    private Camera cam;

    void Start()
    {
        speed = PlayerPrefs.GetFloat("ultimateSpeed");

        target = new Vector2(0.0f, 0.0f);
        position = gameObject.transform.position;

        cam = Camera.main;

    }

    void Update()
    {
        float step = speed * Time.deltaTime;

        transform.position = Vector2.MoveTowards(transform.position, target, step);

       
        
            Vector3 fwd = transform.TransformDirection(Vector3.forward);

            if (Physics.Raycast(transform.position, fwd, 10))
                print("There is something in front of the object!");
        

    }

    void OnGUI()
    {
        Event currentEvent = Event.current;
        Vector2 mousePos = new Vector2();
        Vector2 point = new Vector2();

        mousePos.x = currentEvent.mousePosition.x;
        mousePos.y = cam.pixelHeight - currentEvent.mousePosition.y;
        point = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 0.0f));

        if (Input.mousePresent)
        {
            target = point;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "square")
        {
            SceneManager.LoadScene("EndGame");
        }
    }
}