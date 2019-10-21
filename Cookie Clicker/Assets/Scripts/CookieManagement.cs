using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CookieManagement : MonoBehaviour
{
    public Text countText;
    int cookieCount;

    public GameObject cookie;

    public Button bakerButton;
    public Slider bakerSlider;

    float bakingTime;
    float bakingTimer;
    bool canBake;

    // Start is called before the first frame update
    void Start()
    {
        cookieCount = 0;
        bakingTime = 3;
        bakingTimer = 0;
        canBake = true;

        showBaker(false);
        countText.text = cookieCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (cookieCount == 10)
        {
            showBaker(true);
        }

        if (!canBake)
        {
            bakingTimer += Time.deltaTime;
            bakerSlider.value = bakingTimer;

            if(bakingTimer >= bakingTime)
            {
                cookieCount += 20;
                countText.text = cookieCount.ToString();

                for (int i = 0; i < 20; i++)
                {
                    Instantiate(cookie, transform.position, Quaternion.identity);
                }

                canBake = true;
                bakingTimer = 0;
                bakerButton.interactable = true;
                bakerSlider.value = bakingTimer;

            }
        }
    }

    public void cookieClicked()
    {
        cookieCount++;
        countText.text = cookieCount.ToString();
        Instantiate(cookie, transform.position, Quaternion.identity);
    }

    public void bakerClicked()
    {
        if(cookieCount >= 5)
        {
            canBake = false;
            cookieCount -= 5;
            countText.text = cookieCount.ToString();
        }
        
    }

    void showBaker(bool isShowing)
    {
        bakerButton.gameObject.SetActive(isShowing);
        bakerSlider.gameObject.SetActive(isShowing);
    }
}
