using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseCheese : MonoBehaviour
{
    public Vector3 UltimatePosition = new Vector3(0, 0, 0);
    float X, Y;
    // Start is called before the first frame update
    void Start()
    {
        X = Input.mousePosition.x;
        Y = Input.mousePosition.y;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Input.mousePosition;
        pos.z = transform.position.z - Camera.main.transform.position.z;
        transform.position = Camera.main.ScreenToWorldPoint(pos);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "square")
        {
            SceneManager.LoadScene("EndGame");
        }
    }
}
