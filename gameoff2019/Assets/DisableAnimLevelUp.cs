using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableAnimLevelUp : MonoBehaviour
{
    [SerializeField] ParticleSystem up;


    AudioSource aS;

    private void Start()
    {
        aS = GetComponent<AudioSource>();
        aS.volume = PlayerPrefs.GetFloat("VolumeEffects") / 2;
    }

    public void PlayUp()
    {
        aS.Play();
        up.Play();
    }
    public void DisableLevelUpGameObject()
    {
        up.Stop();
        gameObject.SetActive(false);
    }

}
