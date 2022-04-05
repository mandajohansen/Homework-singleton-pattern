using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    private int _currentScore;
    public static Manager Instance;

    void Awake()
    {
        Instance = this;
    }

    public void AdjustScore(int num)
    {
        _currentScore = _currentScore + num;
    }
    
    void OnGUI() 
    {
        GUI.Label(new Rect(10, 10, 100, 100), "Score =" + _currentScore);
    }

}


