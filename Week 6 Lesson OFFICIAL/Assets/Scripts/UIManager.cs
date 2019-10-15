using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Laura;
    public Text scoreText;

    public void Awake()
    {
        if (Laura == null)
        {
            Laura = this;
            DontDestroyOnLoad(this);
        }
        else if (Laura != this)
        {
            Destroy(gameObject);
        }

    }

    public void ShowNewScore(int score)
    {
        scoreText.text = score.ToString();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
