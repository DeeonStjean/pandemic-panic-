using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StressBar : MonoBehaviour
{
    public static PersistentData data;

    void Start ()
    {
        data = GameObject.FindWithTag("PD").GetComponent<PersistentData>();
    }
    
    void Update ()
    {
        Transform tf = gameObject.GetComponent<Transform>();

        float xVal = -3.5f + ((float)data.GetStress() * 0.035f);
        tf.localPosition = new Vector2(xVal, tf.localPosition.y);
    }
}
