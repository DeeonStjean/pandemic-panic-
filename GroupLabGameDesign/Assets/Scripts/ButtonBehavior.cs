using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehavior : MonoBehaviour
{
    
    public void nextScene() 
    {
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex) + 1);
    }
}
