using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Actions.toggleFlashlight?.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Actions.detonate?.Invoke();
        }
    }
}
