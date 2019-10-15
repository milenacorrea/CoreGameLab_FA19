using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkullMovement : MonoBehaviour
{
    public GameObject skull;
    public Slider skullX;
    public Slider skullY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        skull.transform.position += new Vector3(skullX.value, 0.0f , 0.0f);
        skull.transform.position += new Vector3( 0.0f, skullY.value, 0.0f);
    }
}
