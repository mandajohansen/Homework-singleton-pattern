using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volumeslider : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    void Start()
    {

        Soundmanager.Instance.ChangeMasterVolume(_slider.value);
        _slider.onValueChanged.AddListener(val => Soundmanager.Instance.ChangeMasterVolume(val));
    
        
    }



}
