using UnityEngine;
using UnityEngine.SceneManagement;
public class GoToScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void AR()
    {
         SceneManager.LoadScene("AR");
    }
    public void BASIC()
    {
         SceneManager.LoadScene("Basic");
    }
     public void Menu()
    {
         SceneManager.LoadScene("canvas");
    }
}
