using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
public class WriteMesagePhone : MonoBehaviour
{
    public Text Txt;
    public string Buk;
    public string SmailBuk;
    public Variables Var;
    public AudioSource audioSource;
    public void OnMouseDown()
    {
        if (Var.Can == true)
        {
           if (Txt.text == "")
           {
                Txt.text = "+" + Buk;
                
           }
           else
           {
                Txt.text = Txt.text + Buk;
           }
             audioSource.Play();   
         }
           
      





    }
}
