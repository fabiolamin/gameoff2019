using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMusic : MonoBehaviour
{
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = PlayerPrefs.GetFloat("VolumeMusic");
    }
}
