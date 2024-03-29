﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameManagement Will;

    private void Awake()
    {
        if (Will == null)
        {
            Will = this;
            DontDestroyOnLoad(this);
        }
        else if (Will != this)
        {
            Destroy(this.gameObject);
        }
    }
    public float speed;
    public Slider speedSlider;
    public Text buttonText;

    public void SliderChange()
    {
        speed = speedSlider.value;
        buttonText.text = speed.ToString();

    }
    public void SceneChange(int SCeneNum)
    {
        SceneManager.LoadScene(SceneNum);
    }
}
