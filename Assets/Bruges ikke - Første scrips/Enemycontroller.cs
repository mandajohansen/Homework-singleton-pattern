using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemycontroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Manager.Instance.AdjustScore(-3000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
