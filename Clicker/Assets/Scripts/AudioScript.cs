using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    [SerializeField] public AudioSource audioSource;
    

    void Update()
    {
        audioSource.volume = PlayerPrefs.GetFloat("musicSliderValue");
    }
}
