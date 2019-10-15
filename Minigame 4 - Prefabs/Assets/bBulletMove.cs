using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class bBulletMove : MonoBehaviour
{
    public Text health2;
    int score1;
    // Start is called before the first frame update
    void Start()
    {
        health2.text = "";
        score1 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * 7f);
        health2.text = "" + score1;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            score1 = score1 + 1;
            Destroy(this.gameObject);
        }
        if(score1 == 10)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
