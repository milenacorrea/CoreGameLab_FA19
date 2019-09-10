using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Float : MonoBehaviour
{
    Rigidbody2D rb;
    public float forceamount;
   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        forceamount = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        rb.AddForce(Vector2.up * forceamount);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }
}
