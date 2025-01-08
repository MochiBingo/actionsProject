using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class detonator : MonoBehaviour
{
    public Animator detPress;
    void Start()
    {
        Actions.detonate += pressDetonator;
    }
    void pressDetonator()
    {
        //it resets the animation trigger so the animation can play
        detPress.ResetTrigger("detonateTrigger");
        detPress.SetTrigger("detonateTrigger");

    }
}
