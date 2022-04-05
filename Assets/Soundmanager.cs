using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundmanager : MonoBehaviour
{
    public static Soundmanager Instance;
    
   
   [SerializeField] private AudioSource _beachSource, _scoreSource, _citySource;
   
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else 
        {
            Destroy(gameObject);
        }

    }

    public void PlaySound(AudioClip clip)
    {
        _scoreSource.PlayOneShot(clip);
    }


    public void ChangeMasterVolume(float value)
    {
        AudioListener.volume = value;
    }


    public void ButtonBeach()
    {
        _beachSource.mute = !_beachSource.mute;
    }

    public void ButtonCity()
    {
        _citySource.mute = !_citySource.mute;
    }



}

