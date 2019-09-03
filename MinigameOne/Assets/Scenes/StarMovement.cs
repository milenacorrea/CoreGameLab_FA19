using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarMovement : MonoBehaviour
{
    public float speed;
    public float timer;
    public GameObject star1;
    public GameObject star2;
    public float range;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0;
        timer = 2;
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(5, 0) * Time.deltaTime * speed);
        if (timer >= 2)
        {
            transform.position = new Vector2(Random.Range(-9,9), Random.Range(-9, 9));
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
