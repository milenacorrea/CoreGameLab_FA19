﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakeMoreButtons : MonoBehaviour
{
    public GameObject gridLayout;
    public GameObject button_p;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newButton = Instantiate(button_p, gridLayout.transform.position, Quaternion.identity);
            newButton.transform.parent = gridLayout.transform;
        }
    }
}
