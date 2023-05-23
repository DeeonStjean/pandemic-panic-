using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseAndResume : MonoBehaviour 
{
    GameObject[] pauseMode;
    GameObject[] resumeMode;
    
    private static PersistentData data;

    // Start is called before the first frame update
    void Start()
    {
        pauseMode = GameObject.FindGameObjectsWithTag("ShowOnPause");
        resumeMode = GameObject.FindGameObjectsWithTag("ShowOnResume");

        data = GameObject.FindWithTag("PD").GetComponent<PersistentData>();

        //buttons that should only be showed in pause mode should start off as inactive
        foreach (GameObject g in pauseMode)
            g.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pause()
    {
        if (data.decided)
            return;
            
        Time.timeScale = 0.0f;

        foreach (GameObject g in resumeMode)
            g.SetActive(false);

        foreach (GameObject g in pauseMode)
            g.SetActive(true);
    }

    public void Resume()
    {

        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        // buttons that should only be showed in pause mode should start off as inactive
        // foreach (GameObject g in pauseMode)
        //     g.SetActive(false);

        // foreach (GameObject g in resumeMode)
        //     g.SetActive(true);

    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
