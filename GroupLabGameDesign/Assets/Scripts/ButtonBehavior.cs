using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehavior : MonoBehaviour
{
    public void loadMenu() {
        //AudioSource.Play();
        SceneManager.LoadScene("MainMenu");
    }
    public void loadSettings() {
        SceneManager.LoadScene("Settings");
    }
    public void loadInstructions() {
        SceneManager.LoadScene("Instructions");
    }
    public void nextScene() 
    {
        //AudioSource.PlayClipAtPoint(clickSoundEffect, transform.position);
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex) + 1);
    }
}
