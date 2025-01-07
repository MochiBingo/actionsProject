using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class flashlight : MonoBehaviour
{
    public GameObject lightsource;
    public MeshRenderer lens;
    public Material lightOn;
    public Material lightOff;
    
    // Start is called before the first frame update
    void Start()
    {
        Actions.toggleFlashlight += ToggleLight;
    }

    // Update is called once per frame
    void Update()
    {
    }
    void ToggleLight()
    {
            if (lens.material == lightOn)
            {
                lens.material = lightOff;
                lightsource.SetActive(false);
            }
            else
            {
                lens.material = lightOn;
                lightsource.SetActive(true);
            }
    }
}
