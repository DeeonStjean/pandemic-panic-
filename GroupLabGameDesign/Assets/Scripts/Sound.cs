using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource soundEffectClick;

    public void clickSoundEffect() 
    {
        soundEffectClick.Play();
    }
}
