using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagement1 : MonoBehaviour
{
    public static GameManagement1 Larry;
    // Start is called before the first frame update

    private void Awake()
    {
        if (Larry == null)
        {
            Larry = this;
            DontDestoryOnLoad(this);
            
            else if (Larry != this)
            {
                Destory(gameObject);
            }
            

        }
    }



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
