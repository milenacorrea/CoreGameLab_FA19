using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookieMove : MonoBehaviour
{
    float horz;
    public float speed;
    bool canJump;
    int numJumps;
    int numJumpsAllowed;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        canJump = true;
        numJumpsAllowed = 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        horz = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * horz * speed * Time.deltaTime);

        if (canJump)
        {
            if (numJumps < numJumpsAllowed)
            {
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    rb.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
                    numJumps++;
                }

            }

            else { canJump = false; }

        }

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "ground")
        {
            canJump = true;
            numJumps = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "upgrade")
        {
            numJumpsAllowed = 2;
            Destroy(collision.gameObject);
        }
    }
}
