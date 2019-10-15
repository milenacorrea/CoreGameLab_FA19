using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bBullet : MonoBehaviour
{
    private int score1;
    float timer;
    public GameObject badBullet;
    public Transform bStart1;
    public Transform bStart2;
    public Transform bStart3;
    public Transform bStart4;
    public Transform bStart5;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("LaunchBadBullet", 2.0f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 10)
        {
            Instantiate(badBullet, bStart1.position, bStart1.rotation);
            Instantiate(badBullet, bStart2.position, bStart2.rotation);
            Instantiate(badBullet, bStart3.position, bStart3.rotation);
            Instantiate(badBullet, bStart4.position, bStart4.rotation);
            Instantiate(badBullet, bStart5.position, bStart5.rotation);
        }
    }


    void LaunchBadBullet()
    {
        GameObject instance =
        Instantiate(badBullet, bStart1.position, bStart1.rotation);
        Instantiate(badBullet, bStart2.position, bStart2.rotation);
        Instantiate(badBullet, bStart3.position, bStart3.rotation);
        Instantiate(badBullet, bStart4.position, bStart4.rotation);
        Instantiate(badBullet, bStart5.position, bStart5.rotation);

        //instance.velocity = Random.insideUnitSphere * 5;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            score1 = score1 + 1;
            
        }
        if (score1 == 5)
        {
       
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}

