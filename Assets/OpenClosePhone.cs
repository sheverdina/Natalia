using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class OpenCloseComp : MonoBehaviour
{
    public bool Close;
    public bool Open;
    public int rot;
        public Transform target;
    float smoothTime = 0.3f;
    float yVelocity = 0.0f;
    public float speed = 0.1f;
    void Update()
    {
        if (Open == true)
        {
          
            Opened();
          
        }
        if (Close == true)
        {
            Closed();


        }
    }

   
    public void OnMouseDown()
    {

        if (rot > 90)
        {
            Open = true;
            Close = false;
              
        }
        else if(rot < 90)

        {
           
            Open = false;
            Close = true;
          
        }






    }
    void Closed()
    {
         transform.position = Vector3.Lerp(transform.position, target.position, speed);
        rot = 91;
    }
    void Opened()
    {
        //float newPosition = Mathf.SmoothDamp(transform.position.y, target.position.y, ref yVelocity, smoothTime);
       // transform.position = new Vector3(transform.position.x, newPosition, transform.position.z);
        transform.Translate(target.position.x,target.position.y,target.position.z);
        rot = 0;
    }
}
