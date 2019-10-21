using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public float force;
    float horz;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        horz = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * horz * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * force, ForceMode2D.Impulse);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "children")
        {
            MainManager.Candy.GameOver();
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
