using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSliderPain : MonoBehaviour
{

    public Slider speedControl;
    public Button sceneChanger;
    public Text speedAmount;
    public float ultimateSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("ultimateSpeed", speedControl.value);
        if (speedControl.value > 0)
        {
            speedAmount.text = speedControl.value.ToString("0.0");
        }

    }
}
