using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PersistentData : MonoBehaviour
{
    // Months will be treated as rounds (sort of).
    [SerializeField] int month = 0;

    // Stress and the tolerance the player has.
    // If stress grows more than tolerance, game over.
    [SerializeField] private int stress = 0;

    // Happiness of the citizens.
    [SerializeField] private int happiness = 50;

    // Cases and the rate they progress.
    [SerializeField] int cases = 0;
    [SerializeField] float caseRate = 1.0f;

    // Deaths and the rate they progress.
    [SerializeField] int deaths = 0;
    [SerializeField] float deathRate = 1.0f;


    public StressBar stressBar;

    // PersistentData.
    public static PersistentData Instance;

    public void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(this);
            Instance = this;
        }
        else
            Destroy(gameObject);
    }

    public void alterHappiness (int happiness)
    {
        this.happiness += happiness;
    }

    public void verifyContinue ()
    {
        if (happiness <= 10)
            //Riot
            SceneManager.LoadScene("GameOverScene2");
        else if (stress >= 100)
            //Too Stressed
            SceneManager.LoadScene("GameOverScene1");
    }

    public int GetStress ()
    {
        return stress;
    }

    public int GetHappiness ()
    {
        return happiness;
    }
}
