using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasSettings : MonoBehaviour
{
    [SerializeField] Slider sliderMusic;
    [SerializeField] Slider sliderEffects;
    [SerializeField] AudioSource musicScene;
    public void Start()
    {
        sliderMusic.value = PlayerPrefs.GetFloat("VolumeMusic");
        sliderEffects.value = PlayerPrefs.GetFloat("VolumeEffects");
    }
    public void ChangeMusic()
    {
        musicScene.volume = sliderMusic.value;
        PlayerPrefs.SetFloat("VolumeMusic", sliderMusic.value);
    }
    public void ChangeEffect()
    {
        PlayerPrefs.SetFloat("VolumeEffects", sliderEffects.value);
    }

}
