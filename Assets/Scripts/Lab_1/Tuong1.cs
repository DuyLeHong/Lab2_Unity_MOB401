using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuong1 : MonoBehaviour
{
    public float left, right;
    private bool isRight;
    
    void Start()
    {
        
    }
   
    void Update()
    {
        var caX = transform.position.x;
        if (caX < left)
        {
            isRight = true;
        }

        if (caX > right)
        {
            isRight = false;
        }

        if (isRight)
        {
            transform.Translate(new Vector3(Time.deltaTime * 1,0,0));
        }
        else
        {
            transform.Translate(new Vector3(-Time.deltaTime * 1,0,0));
        }
    } 
}
