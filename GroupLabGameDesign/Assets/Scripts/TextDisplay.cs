using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextDisplay : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    [SerializeField] public string[] lines;
    private bool isQuestion = true;

    public float textSpeed;

    public AudioSource textSound;
    private int index;

    private GameObject[] decisions;

    // Start is called before the first frame update
    void Start()
    {
        lines[0] = textComponent.text;

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

            if (textComponent.text[textComponent.text.Length-1] == '?' && isQuestion)
                foreach (GameObject o in decisions)
                    o.SetActive(true);

            yield return new WaitForSeconds(textSpeed);
        }
    }

    private void Disable ()
    {
        foreach (GameObject o in decisions)
            o.SetActive(false);
    }
    public void Decision1 ()
    {
        index = UnityEngine.Random.Range(1,3);
        textComponent.text = "";
        StartCoroutine(TypeLine());
        Disable();
        isQuestion = false;
    }

    public void Decision2 ()
    {
        index = UnityEngine.Random.Range(3,5);
        textComponent.text = "";
        StartCoroutine(TypeLine());
        Disable();
        isQuestion = false;
    }

    public void Decision3 ()
    {
        index = UnityEngine.Random.Range(5,7);
        textComponent.text = "";
        StartCoroutine(TypeLine());
        Disable();
        isQuestion = false;
    }
}
