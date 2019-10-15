using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gBullet : MonoBehaviour
{
    public GameObject goodBullet;
    public Transform gStart;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(goodBullet, gStart.position, gStart.rotation);
        }
    }
}
