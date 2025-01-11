using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;


public class Phone : MonoBehaviour
{
    public Text Txt;
    
    public float timer;
    public bool Need;
    public Variables Var;
    public AudioSource audioSource;
    public void OnMouseDown()
    {
    
        
        if (Var.Can == true && Txt.text != "+")
        {
                 audioSource.Play();
                Var.Need = true;
                 Var.Can = false;
                timer = 0;
      
        }
        
       
    }
    void Update()

    {
        if (Var.Need == true) { 
        timer = timer +Time.deltaTime;
            string textEd = "Звонок ";

            Txt.text = textEd;
        }
    
       
    }
}