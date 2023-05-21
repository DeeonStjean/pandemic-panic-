using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DecisionArray : MonoBehaviour
{
    private static DecisionArray instance;
    private const int DECISION_AMOUNT = 4;
    private int index = 0;

    [SerializeField] public int[] decisions;
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

        decisions = new int[DECISION_AMOUNT];
    }

    void Update ()
    {
        try
        {
            text = GameObject.FindWithTag("Reporter").GetComponent<TextMeshProUGUI>();
        }
        catch (Exception e)
        {
            // Crickets..
        }
    }

    public void addDecision (int id)
    {
        decisions[index] = id;
        index++;
    }

    public void report ()
    {
        if (index != 0)
        {
            switch (decisions[index-1])
            {
                case 101:
                    text.text = "We have realized everything will be fine.";
                    break;
                case 102:
                    text.text = "We have realized someone over here farted and it stinks.";
                    break;
            }
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            return;
        }
        
        decisions[index-1] = 0;
        index--;
    }
}
