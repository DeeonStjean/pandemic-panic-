using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HappinessBarBackground : MonoBehaviour
{
    private static PersistentData data;
    [SerializeField] int type = 0;

    [SerializeField] GameObject red;
    [SerializeField] GameObject yel;
    [SerializeField] GameObject gre;

    void Start ()
    {
        data = GameObject.FindWithTag("PD").GetComponent<PersistentData>();
    }
    void Update()
    {
        if (data.happiness <= 29)
            red.SetActive(true);
        else
            red.SetActive(false);

        if (data.happiness > 29 && data.happiness <= 70)
            yel.SetActive(true);
        else
            yel.SetActive(false);

        if (data.happiness >= 71)
            gre.SetActive(true);
        else
            gre.SetActive(false);

        gameObject.GetComponent<Slider>().value = data.happiness;
    }
}
