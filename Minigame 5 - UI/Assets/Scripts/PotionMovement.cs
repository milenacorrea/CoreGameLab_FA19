using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PotionMovement : MonoBehaviour
{

    Rigidbody2D rb;
    public float forceamount;

    private float badscore;
    public Text loser;

    private bool completion;
    public GameObject potion;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        badscore = 0;
        completion = false;
    }

    // Update is called once per frame
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb.AddForce(new Vector2(Random.Range(-1.0f, 1.0f), 1.0f) * forceamount, ForceMode2D.Impulse);

        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            badscore = badscore + 1 ;
        }


        if (badscore > 1)
        {
            completion = true;
            loser.text = "You lost! Press the button to restart!";
        }
    }

    void Update()
    {
        Debug.Log(badscore);
    }
}
