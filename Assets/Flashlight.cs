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

    private bool isLightOn = false;
    void Start()
    {
        Actions.toggleFlashlight += ToggleLight;
        Actions.interact += pickup;
    }
    void pickup()
    {

    }
    void ToggleLight()
    {
            if (isLightOn == false)
            {
                lens.material = lightOn;
                lightsource.SetActive(true);
                isLightOn = true;
            }
            else if (isLightOn == true)
            {
                lens.material = lightOff;
                lightsource.SetActive(false);
                isLightOn = false;
            }
    }
}
