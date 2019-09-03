using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManMovement : MonoBehaviour
{
    public float speed;
    public float timer;
    public GameObject man;
    float posx;
    float posy;
    public float freq;
    public float amp;

    // Start is called before the first frame update
    void Start()
    {
        speed = 2;
        timer = 2;

        man.transform.position = new Vector2(0, 0);
        freq = 2;
        amp = 2;
    }

    // Update is called once per frame
    void Update()
    {
        posx = Mathf.Sin(Time.time * freq) * Mathf.Sin(Time.time) * amp;
        posy = Mathf.Cos(Time.time * freq) * Mathf.Sin(Time.time) * amp;

        man.transform.Rotate(0, 2, 0 * speed);
        man.transform.position = new Vector2(posx + transform.position.x, posy + transform.position.y);
    }
 
}
