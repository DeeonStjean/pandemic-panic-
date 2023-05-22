using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DecisionArray : MonoBehaviour
{
    private static DecisionArray instance;

    [SerializeField] public int decisions;
    [SerializeField] public TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        //Avoid duplicates.
        if (instance == null)
        {
            DontDestroyOnLoad(this);
            instance = this;
        }
        else
            Destroy(gameObject);
    }

    public void report ()
    {

    }
}
