using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BossHP : MonoBehaviour
{
    public Text health2;
    int score1;
    // Start is called before the first frame update
    void Start()
    {
        health2.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        health2.text = "" + score1;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            score1 = score1 + 1;

        }

        if(score1 == 10)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
