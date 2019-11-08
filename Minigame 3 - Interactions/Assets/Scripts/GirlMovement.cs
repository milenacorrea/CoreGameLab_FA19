using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GirlMovement : MonoBehaviour
{

    // WARNING... THIS CODE IS A BIG MESS LOL AND HARD TO READ... but it was the only way i could think of it working so :)

    public GameObject girl;

    public Transform start8;
    public Transform end8;

    public Transform start1;
    public Transform end1;

    public Transform start6;
    public Transform end6;

    public Transform start4;
    public Transform end4;

    public Transform start9;
    public Transform end9;

    public Transform start3;
    public Transform end3;

    public Transform start2;
    public Transform end2;

    float speed;
    float speed1;
    public Animator play;
    bool walk;

    float startTime8;
    float startTime1;
    float startTime6;
    float startTime4;
    float startTime9;
    float startTime3;
    float startTime2;

    float journeyLength;

    float distCovered;
    float fractionOfJourney;

    // Start is called before the first frame update
    void Start()
    {
        startTime8 = Time.time;
        startTime1 = Time.time;
        startTime6 = Time.time;
        startTime4 = Time.time;
        startTime9 = Time.time;
        startTime3 = Time.time;
        startTime2 = Time.time;

        speed = 3.0f;
        speed1 = 1.0f;

        play = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (walk == true)
        {
            play.SetBool("girlWalk", true);
        }

        if (walk == false)
        {
            play.SetBool("girlWalk", false);
        }

        if (Input.GetKey(KeyCode.Alpha8))
        {
            walk = true;
            journeyLength = Vector3.Distance(start8.position, end8.position);
            distCovered = (Time.time - startTime8) * speed;
            fractionOfJourney = distCovered / journeyLength;

            girl.transform.position = Vector3.MoveTowards(start8.position, end8.position, fractionOfJourney);

            if (girl.transform.position == end8.position)
            {
                walk = false;
            }

            if (Input.GetKey(KeyCode.Alpha1))
            {
                journeyLength = Vector3.Distance(start1.position, end1.position);
                distCovered = (Time.time - startTime1) * speed;
                fractionOfJourney = distCovered / journeyLength;

                walk = true;

                girl.transform.position = Vector3.MoveTowards(start1.position, end1.position, fractionOfJourney);

               // if (girl.transform.position == end1.position)
              //  {
               //     walk = false;
               // }

                if (Input.GetKey(KeyCode.Alpha6))
                {
                    journeyLength = Vector3.Distance(start6.position, end6.position);
                    distCovered = (Time.time - startTime6) * speed;
                    fractionOfJourney = distCovered / journeyLength;

                    walk = true;

                    girl.transform.position = Vector3.MoveTowards(start6.position, end6.position, fractionOfJourney);

                 //   if (girl.transform.position == end6.position)
                 //   {
                 //       walk = false;
                 //   }

                    if (Input.GetKey(KeyCode.Alpha4))
                    {
                        journeyLength = Vector3.Distance(start4.position, end4.position);
                        distCovered = (Time.time - startTime4) * speed;
                        fractionOfJourney = distCovered / journeyLength;

                        walk = true;

                        girl.transform.position = Vector3.MoveTowards(start4.position, end4.position, fractionOfJourney);

                       // if (girl.transform.position == end4.position)
                       // {
                       //     walk = false;
                       // }

                        if (Input.GetKey(KeyCode.Alpha9))
                        {
                            journeyLength = Vector3.Distance(start9.position, end9.position);
                            distCovered = (Time.time - startTime9) * speed;
                            fractionOfJourney = distCovered / journeyLength;

                            walk = true;

                            girl.transform.position = Vector3.MoveTowards(start9.position, end9.position, fractionOfJourney);

                         //   if (girl.transform.position == end9.position)
                         //   {
                          //      walk = false;
                         //   }

                            if (Input.GetKey(KeyCode.Alpha3))
                            {

                                journeyLength = Vector3.Distance(start3.position, end3.position);
                                distCovered = (Time.time - startTime3) * speed;
                                fractionOfJourney = distCovered / journeyLength;

                                walk = true;

                                girl.transform.position = Vector3.MoveTowards(start3.position, end3.position, fractionOfJourney);

                           //     if (girl.transform.position == end3.position)
                          //      {
                            //        walk = false;
                           //     }

                                if (Input.GetKey(KeyCode.Alpha2))
                                {

                                    journeyLength = Vector3.Distance(start2.position, end2.position);
                                    distCovered = (Time.time - startTime2) * speed;
                                    fractionOfJourney = distCovered / journeyLength;

                                    walk = true;

                                    girl.transform.position = Vector3.MoveTowards(start2.position, end2.position, fractionOfJourney);

                                    if (girl.transform.position == end2.position)
                                    {
                                        SceneManager.LoadScene("End Game");
                                    }
                                }
                            }
                        }

                    }


                }



            }

        }

    }
}
