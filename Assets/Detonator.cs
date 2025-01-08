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
        detPress.ResetTrigger("detonateTrigger");
        detPress.SetTrigger("detonateTrigger");

    }
}
