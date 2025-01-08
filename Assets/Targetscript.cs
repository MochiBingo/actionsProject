using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Targetscript : MonoBehaviour
{
    public GameObject target;
    public GameObject brokenTarget;
    private void Start()
    {
        Actions.detonate += destoyTarget;
    }
    void destoyTarget()
    {
        //turn off the intact target and turn on the destroyed target
        target.SetActive(false);
        brokenTarget.SetActive(true);
    }
}
