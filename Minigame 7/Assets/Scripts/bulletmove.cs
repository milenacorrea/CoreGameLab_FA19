using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletmove : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(Vector2.up * Time.deltaTime * 7f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
