using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject avatar;
    public float moveX;
    public float moveY;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Input.mousePosition);

        //Makes it so that character moves to new position depending on keys pressed
        //References: https://docs.unity3d.com/ScriptReference/KeyCode.html
        // https://gamedev.stackexchange.com/questions/92759/unity-3d-4-players-only-4-buttons-can-be-pressed-at-a-time
        // https://stackoverflow.com/questions/45346539/c-sharp-converting-type-double-to-float
        if (Input.GetKey(KeyCode.Alpha8))
            {
                //For help
                avatar.transform.position = new Vector3(-2.09f, -2.8f, 0);
                Debug.Log("8");

                if (Input.GetKey(KeyCode.Alpha1))
                {
                    avatar.transform.position = new Vector3(-3.55f, -1.07f, 0);
                    Debug.Log("81");

                    if (Input.GetKey(KeyCode.Alpha6))
                    {
                        avatar.transform.position = new Vector3(-3.24f, 1.23f, 0);
                        Debug.Log("816");

                        if (Input.GetKey(KeyCode.Alpha4))
                        {
                            avatar.transform.position = new Vector3(-2.16f, 2.99f, 0);
                            Debug.Log("8164");

                            if (Input.GetKey(KeyCode.Alpha9))
                            {
                                avatar.transform.position = new Vector3(-0.01f, 3.82f, 0);
                                Debug.Log("81649");

                                if (Input.GetKey(KeyCode.Alpha3))
                                {
                                    avatar.transform.position = new Vector3(2.26f, 2.81f, 0);
                                    Debug.Log("816493");

                                    if (Input.GetKey(KeyCode.Alpha2))
                                    {
                                        avatar.transform.position = new Vector3(3.43f, 1.43f, 0);
                                        Debug.Log("8164932");

                                       // if (Input.GetKeyDown(KeyCode.Alpha7))
                                       // {
                                       //     avatar.transform.position = new Vector3(3.4f, -1.14f, 0);
                                       //     Debug.Log("81649327");
                                       //
                                       //     if (Input.GetKeyDown(KeyCode.Alpha5))
                                       //
                                       //     {
                                       //         avatar.transform.position = new Vector3(2.05f, -2.9f, 0);
                                       //         Debug.Log("816493275");
                                       //     }
                                        }

                                    }
                                }
                            }
                        }
                    }
                }
            }

        }
    

