using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstellationMovement : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate (new Vector2(5,0) * Time.deltaTime * speed);

        if(transform.position.x >=17)
        {
            transform.position = new Vector2(-17, Random.Range(-3,3));
            //transform.Translate(new Vector2(Random.Range(-3, 5), (Random.Range(-5, 5))) * Time.deltaTime);
        }

    }

}

