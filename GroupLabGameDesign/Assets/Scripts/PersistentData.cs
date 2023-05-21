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
    [SerializeField] int stress;
    [SerializeField] int tolerance;

    // Happiness of the citizens.
    [SerializeField] int happiness;

    // Cases and the rate they progress.
    [SerializeField] int cases;
    [SerializeField] float caseRate;

    // Deaths and the rate they progress.
    [SerializeField] int deaths;
    [SerializeField] float deathRate;


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

    void Start() {
        stress = 0;
        tolerance = 100;
        happiness = 50;
       
    }

    public void SStress(int stress)
    {
        stressBar.SetStress(stress);
    }

    void Update () {}

    public int GetStress()
    {
        return stress;
    }

    public void advanceMonth()
    {
        /*
            With each month advanced, the cases/deaths will grow.
            It is tied to their rates, and happiness should follow.

            Cases will be tied to their decisions.
        */
    }

    public void alterHappiness (int happiness)
    {
        this.happiness += happiness;
    }

    public void verifyContinue ()
    {
        /*
            If stress too high OR
            happiness too low, game over.
        */
    }
}
