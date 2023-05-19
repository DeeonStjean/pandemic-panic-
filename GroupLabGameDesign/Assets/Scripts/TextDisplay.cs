using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextDisplay : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;

    public float textSpeed;

    public AudioSource textSound;
    private int index;

    private GameObject[] decisions;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty; 
        StartDialogue();

        decisions = GameObject.FindGameObjectsWithTag("Decision");
        
        foreach (GameObject o in decisions)
            o.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
         if (textSound.time > 7.5f)
        {
            textSound.Stop();
        }
    }

    void StartDialogue() 
    {
        index = 0;
        textSound.Play();
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray()) 
        {
            textComponent.text += c;

            if (textComponent.text[textComponent.text.Length-1] == '?')
                foreach (GameObject o in decisions)
                    o.SetActive(true);

            yield return new WaitForSeconds(textSpeed);
        }
    }
}
