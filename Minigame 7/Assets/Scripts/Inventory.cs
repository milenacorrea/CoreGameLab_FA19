using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public bool gotGun;
    public Text gunAmount;
    public int totalBullets;
    public Text bulletAmount;
    // Start is called before the first frame update
    void Start()
    {
        gunAmount.text = "0";
        bulletAmount.text = "0";
        totalBullets = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (gotGun == true)
        {
            gunAmount.text = "1";
        }

        bulletAmount.text = "" + totalBullets;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "gun")
        {
            gotGun = true;
            Destroy(collision.gameObject);
            Debug.Log("gun");
        }

        if(collision.gameObject.tag == "bullets")
        {
            totalBullets = totalBullets + 2;
            Destroy(collision.gameObject);
            Debug.Log("bullet");

        }
    }
}
