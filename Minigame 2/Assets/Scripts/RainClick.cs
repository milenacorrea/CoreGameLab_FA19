using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainClick : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // taking the mouse position and converting to vector3
            Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //Debug.Log("Mouse click detected >:)" + worldPoint.x + " " + worldPoint.y);

            Vector3 direction = worldPoint - transform.position;
            rb.AddForce(new Vector2(direction.x, direction.y), ForceMode2D.Impulse);
        }
        
        else
        {
            rb.AddForce(new Vector2(0, 0), ForceMode2D.Impulse);        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
