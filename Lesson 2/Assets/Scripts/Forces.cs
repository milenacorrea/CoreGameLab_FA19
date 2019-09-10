using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forces : MonoBehaviour
{
    Rigidbody2D rb;
    public float forceamount;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(Random.Range(-1.0f, 1.0f), 1.0f) * forceamount, ForceMode2D.Impulse);

        //give it a vector and what direction its going to
        //mode is how you are applying that force
    }

    private void OnCollisionEnter2D(Collision2D collision)
    //when the collission object gets called, this is automatically filled with the object we are colliding with.
    //private is within the script only
    {
        if (collision.gameObject.tag == "ColorChangingPlatform")
        {
            collision.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }

        Debug.Log("collision!!" + collision.gameObject.name);
        
        //you can type in RGB values

       //another way of doing it
       //SpriteRenderer sr = collision.gameObject.GetComponent<SpriteRenderer>();
       //sr.color = Color.red;
    }
}
