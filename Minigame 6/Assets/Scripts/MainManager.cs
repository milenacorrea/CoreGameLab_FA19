using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    public static MainManager Candy;

    private void Awake()
    {
        if (Candy == null)
        {
            Candy = this;
            DontDestroyOnLoad(this);
        }
        else if (Candy != this)
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Level2()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void Level3()
    {
        SceneManager.LoadScene("Level 3");
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Game Over");
    }

    public void GameWin()
    {
        SceneManager.LoadScene("Game Win");
    }
}
