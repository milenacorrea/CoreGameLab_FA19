using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{ 
    public Transform platform;
    public float speed;
   
    // Start is called before the first frame update
    void Start()
    {
        speed = 50;
    }

    // Update is called once per frame
    void Update()
    {
        //https://answers.unity.com/questions/1366140/rotate-gameobject-on-z-axis-with-mouse-x-movement.html
        transform.Rotate(0,0, (Input.GetAxis("Mouse X")) * Time.deltaTime * speed);
    }
}
