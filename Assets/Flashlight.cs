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
    }
    void ToggleLight()
    {
        //on toggle, if the light is off it turns it on, turning on the light and switching the material
            if (isLightOn == false)
            {
                lens.material = lightOn;
                lightsource.SetActive(true);
                isLightOn = true;
            }
        //if the light is on it turns it off
            else if (isLightOn == true)
            {
                lens.material = lightOff;
                lightsource.SetActive(false);
                isLightOn = false;
            }
    }
}
