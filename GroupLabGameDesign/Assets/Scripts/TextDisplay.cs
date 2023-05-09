using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextDisplay : MonoBehaviour
{
    public TextMeshProUGUI textDesc;
    public string[] lines;
    public float textSpeed;
    //public AudioSource textSound;
    private int index;
    // Start is called before the first frame update
    void Start()
    {
        textDesc.text = string.Empty;
        StartDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartDialogue() 
    {
        index = 0;
        StartCoroutine(TypeLine());
    }
    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray()) 
        {
            textDesc.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }
}
