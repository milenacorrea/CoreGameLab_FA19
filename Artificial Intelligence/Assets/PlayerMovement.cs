using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//lol! u suck :D
public class PlayerMovement : MonoBehaviour
{
    float speed;
    int coinCount;
    public Slider coinSlider;
    List<GameObject> coins = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        speed = 4f; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            //Destroy(collision.gameObject);

            collision.gameObject.SetActive(false);
            coins.Add(collision.gameObject);
            coinCount++;
            coinSlider.value = coinCount;
        }

        if (collision.gameObject.tag == "patrol")
        {
            //Destroy(collision.gameObject);

            coinCount--;
            coinSlider.value = coinCount;

            if (coins.Count > 0)
            {
                int randomCoin = Random.Range(0, coins.Count);
                coins[randomCoin].gameObject.SetActive(true);
                coins.Remove(coins[randomCoin]);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("you in da box bby");
        PatrolMovement.isChasing = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("you out of da box bby");
        PatrolMovement.isChasing = false;
    }
}
