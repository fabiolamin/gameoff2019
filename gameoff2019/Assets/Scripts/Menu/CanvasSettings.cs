using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasSettings : MonoBehaviour
{
    [SerializeField] Slider sliderMusic;
    [SerializeField] Slider sliderEffects;
    [SerializeField] AudioSource musicScene;
    [SerializeField] AudioSource[] effectScene;
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
        effectScene[0].volume = sliderEffects.value;
        effectScene[1].volume = sliderEffects.value;
        PlayerPrefs.SetFloat("VolumeEffects", sliderEffects.value);
    }

}
