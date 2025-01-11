using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;


public class UncallScript : MonoBehaviour
{
    public Text Txt;
    public Text comp;
    public float timer;
    public bool Need;
    public Variables Var;
    public AudioSource audioSource;
    public AudioSource audioSourceTwo;
    public void OnMouseDown()
    {
    
        string textEd = "";
        
        Txt.text = textEd;
        audioSource.Play();
        audioSourceTwo.Stop();
        Var.Can = true;
        Var.Need = false;
    }
   
}