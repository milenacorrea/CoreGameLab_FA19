using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public float force;
    float horz;

    bool isGrounded;
    bool jump;
    bool walk;

    Animator player;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (walk == true)
        {
            player.SetBool("isWalking", true);
        }
        if (jump == true)
        {
            player.SetBool("isJumping", true);
        }


        horz = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * horz * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded == true)
            {
                jump = true;
                rb.AddForce(Vector2.up * force, ForceMode2D.Impulse);
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            walk = true;
        }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            walk = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "children")
        {
            MainManager.Candy.GameOver();
        }

        if (collision.gameObject.tag == "platform" )
        {
            isGrounded = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "end")
        {
            MainManager.Candy.Level2();
        }

        if (collision.gameObject.tag == "end2")
        {
            MainManager.Candy.Level3();
        }

        if (collision.gameObject.tag == "end3")
        {
            MainManager.Candy.GameWin();
        }
    }
}
