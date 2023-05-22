using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehavior : MonoBehaviour
{
    public static DecisionArray instance;

    void Start ()
    {
        instance = GameObject.FindWithTag("Decisionkeeper").GetComponent<DecisionArray>();
    }

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
    public void LoadM1NewsScene1()
    {
        SceneManager.LoadScene("m1NewsSegment");
    }
    public void LoadM1NewsScene2()
    {
        SceneManager.LoadScene("m1NewsSegment#2");
    }

    public void LoadM2NewsScene1()
    {
        SceneManager.LoadScene("m2NewsSegment");
    }
    public void LoadM2NewsScene2()
    {
        SceneManager.LoadScene("m2NewsSegment#2");
    }

    public void loadNextDes()
    {
        SceneManager.LoadScene("m2week1des1");
    }
    public void loadNextDes2() {
        SceneManager.LoadScene("m3week1des1");
    }

}
