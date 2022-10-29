using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsScript : MonoBehaviour
{
    [SerializeField] public Slider musicSlider;
    public static float musicSliderValue=0.5f;

    private void Start()
    {
        musicSliderValue = PlayerPrefs.GetFloat("musicSliderValue");
        musicSlider.value = musicSliderValue;
    }
    
    void Update()

    {
        musicSlider.onValueChanged.AddListener((v) => musicSliderValue = v);
        PlayerPrefs.SetFloat("musicSliderValue", musicSliderValue);
    }

}
