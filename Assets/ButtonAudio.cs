using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAudio : MonoBehaviour
{
 
    [SerializeField] private bool _Sound1, _Sound2;

    public void ButtonsSound()
    {
        if(_Sound1) Soundmanager.Instance.ButtonBeach();
        if(_Sound2) Soundmanager.Instance.ButtonCity();
    }

    
}
