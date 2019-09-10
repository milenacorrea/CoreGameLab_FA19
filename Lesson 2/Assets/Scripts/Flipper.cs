using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//when I hit a collider, logic gets flipped
public class Flipper : MonoBehaviour
{
    Rigidbody2D rb;
    bool isGravityDown;

    public float gravityScale;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isGravityDown = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGravityDown)
        {
            rb.gravityScale = 1;


        }
        else
        {
            rb.gravityScale = -1;
        }

        
        
    }

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGravityDown = !isGravityDown; //! = flips it  
    }

}
