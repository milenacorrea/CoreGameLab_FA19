using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gBulletMove : MonoBehaviour
{
    //float timer;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * 7f);
       // timer += Time.deltaTime;
       // if (timer > 1f)
       // {
         //   Destroy(this.gameObject);
        //}
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
        }
    }
}
