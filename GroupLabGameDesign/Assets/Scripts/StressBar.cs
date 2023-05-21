using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StressBar : MonoBehaviour
{

    public Slider slider;

    public void SetMaxStress(int health)
    {
        slider.maxValue = health;        
    }

    public void SetStress(int health)
    {
        slider.value = health;
    }
}
