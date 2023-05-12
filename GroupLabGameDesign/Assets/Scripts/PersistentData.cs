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
    [SerializeField] int stress = 0;
    [SerializeField] int tolerance = 100;

    // Happiness of the citizens.
    [SerializeField] int happiness = 50;

    // Cases and the rate they progress.
    [SerializeField] int cases = 0;
    [SerializeField] float caseRate = 1.0f;

    // Deaths and the rate they progress.
    [SerializeField] int deaths = 0;
    [SerializeField] float deathRate = 1.0f;


    public HealthBar stressBar;

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

    void Start () {}

    void Update () {}

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
