using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedyFingers : MonoBehaviour
{
    float timer;
    bool GtoH;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (GtoH)
        {
            if(Input.GetKeyDown(KeyCode.H))
            {
                text.text = timer.ToString();
                timer = 0;
                GtoH = false;
            }
        }
        
        else
        {
            if(Input.GetKeyDown(KeyCode.G))
            {
                text.text = timer.ToString();
                timer = 0;
                GtoH = true;
            }
        }
        timer += Time.deltaTime;
    }  
}

// Pseudo Code
// Check if hit 1 button
// start timeer
// if hit other button
// stop other timer, start new timer
// repeat
// print timer value