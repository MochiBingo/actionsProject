using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private bool itemsEquipped = false;
    public GameObject flashText;
    public GameObject detText;
    void Update()
    {
        //key inputs to invoke actions
        if (Input.GetKeyDown(KeyCode.F))
        {
            Actions.toggleFlashlight?.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            //it can only detonate if you're holding the detonator
            if (itemsEquipped == true)
            {
                Actions.detonate?.Invoke();
            }
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Actions.interact?.Invoke();
            itemsEquipped = true;
            detText.SetActive(true);
            flashText.SetActive(true);
        }
    }
}
