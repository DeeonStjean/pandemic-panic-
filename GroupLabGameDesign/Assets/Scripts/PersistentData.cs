using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PersistentData : MonoBehaviour
{
    [SerializeField] int stress;
    [SerializeField] int infected;
    [SerializeField] float happines;
    [SerializeField] long alive;

    public HealthBar stressBar;
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
    void Start()
    {
        stress = 0;
        happines = 70.0f;
        infected = 0;
        alive = 300000000;
    }

    public void SetStress(int stress)
    {
        stressBar.SetHealth(stress);
    }

    public void SetInfected(int inf)
    {
        infected = inf;
    }

    public void SetHappines(float happ)
    {
        happines = happ;
    }

    public void SetAlive(long aliv)
    {
        alive = aliv;
    }

    public int GetStress()
    {
        return stress;
    }

    public int GetInfected()
    {
        return infected;
    }

    public long GetAlive()
    {
        return alive;
    }

    public float GetHappines()
    {
        return happines;
    }
    // Update is called once per frame
    void Update()
    {
     
    }
}
