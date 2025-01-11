using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPhone : MonoBehaviour
{
    
    public float timer;
    public GameObject Screnn;
    public Variables Var;
     public AudioSource audioSourceTwo;
    public void OnMouseDown()
    {
       
        if(Screnn.activeInHierarchy == false)
            {
             Screnn.SetActive(true);
             
                Var.Can = true;


              } else {
                Screnn.SetActive(false);
                Var.Can = false;
                audioSourceTwo.Stop();
        }
        
    }

    void Update()
    {
               

    }
}
