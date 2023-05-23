using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class NewsText : MonoBehaviour
{
    [SerializeField] public string[] lines;
    [SerializeField] public TextMeshProUGUI textComponent;
    [SerializeField] public int nextScene;

    [SerializeField] float textSpeed = 0.04f;

    private int index = -1;


    public void updateText()
    {
        index++;

        textComponent.text = "";

        if (index == lines.Length)
            SceneManager.LoadScene(nextScene);

        StartCoroutine(UpdateText());

        
    }

    IEnumerator UpdateText ()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }
}
