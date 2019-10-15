using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float forceamount;
    private float score;
    public GameObject heart;

    public Text winner;
    public Vector3 range;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        score = 0;

        // Instantiate(heart, range, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (score++ > 4)
        {
            winner.text = "You win! You got all the hearts!";
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb.AddForce(new Vector2(Random.Range(-1.0f, 1.0f), 1.0f) * forceamount, ForceMode2D.Impulse);

        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            score+=1;
        }
    }
}


