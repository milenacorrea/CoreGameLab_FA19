using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BallBounce : MonoBehaviour
{
    public GameObject ball;

    public Transform ballLoc;

    public AudioClip boing;
    bool checkDestroy;

    // Start is called before the first frame update
    void Start()
    {
       // checkDestroy = false;
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = boing;

        //Instantiate(ball, new Vector3(Random.Range(-10f, 10f), 0, 0), Quaternion.identity);
        //not working lol! hilarious dont enable or else it'll crash unity ;) because it creates like a million balls
        
    }

    // Update is called once per frame
    void Update()
    {
        
        // barely works! lol
        if (transform.position.y <= -5f || transform.position.y >= 5f || transform.position.x <= -10f || transform.position.x >= 10f)
        {
            Destroy(this.gameObject);
            checkDestroy = true;
        }

       // if(checkDestroy)
        //{
        //    Vector3 ballX = new Vector3(Random.Range(-10.0f, 10.0f), 0, 0);
       //     Instantiate(ball, ballX, Quaternion.identity);
       // }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //was supposed to change color... doesnt work either!! lol
        if (collision.gameObject.tag == "platform")
        { 

            //collision.gameObject.GetComponent<SpriteRenderer>().color = platform.color;
        }

        
        // https://answers.unity.com/questions/1159138/playing-audio-on-collision.html
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
