using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class detonator : MonoBehaviour
{
    public Animator detPress;
    // Start is called before the first frame update
    void Start()
    {
        Actions.detonate += pressDetonator;
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void pressDetonator()
    {
        detPress.ResetTrigger("detonateTrigger");
        detPress.SetTrigger("detonateTrigger");

    }
}
