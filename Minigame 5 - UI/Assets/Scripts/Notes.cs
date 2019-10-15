using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    public GameObject skullNote;
    public Transform skullPosition;
    public GameObject heartNote;
    public Transform heartPosition;
    public GameObject potionNote;
    public Transform potionPosition;
    public GameObject crossNote;
    public Transform crossPosition;

    float timer;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("LaunchNote", 5.0f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 10)
        {
            Instantiate(skullNote, skullPosition.position, skullPosition.rotation);
            Instantiate(heartNote, heartPosition.position, heartPosition.rotation);
            Instantiate(potionNote, potionPosition.position, potionPosition.rotation);
            Instantiate(crossNote, crossPosition.position, crossPosition.rotation);
        }
    }

    void LaunchNote()
    {
        GameObject instance =
            Instantiate(skullNote, skullPosition.position, skullPosition.rotation);
            Instantiate(heartNote, heartPosition.position, heartPosition.rotation);
            Instantiate(potionNote, potionPosition.position, potionPosition.rotation);
            Instantiate(crossNote, crossPosition.position, crossPosition.rotation);
    }

    void OnBecomeInvisible()
    {
        Destroy(skullNote);
        Destroy(crossNote);
        Destroy(heartNote);
        Destroy(potionNote);
    }

}
