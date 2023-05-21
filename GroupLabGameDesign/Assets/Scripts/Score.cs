using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    [SerializeField] int stress = 0;
    // Start is called before the first frame update
    void Start()
    {
        stress = PersistentData.Instance.GetStress();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
