using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyObjects : MonoBehaviour
{
    public GameObject dummyFlash;
    public GameObject mainFlash;
    public GameObject dummyDet;
    public GameObject mainDet;
    void Start()
    {
        Actions.interact += pickup;
    }
    void pickup()
    {
        dummyFlash.SetActive(false);
        mainFlash.SetActive(true);
        dummyDet.SetActive(false);
        mainDet.SetActive(true);
    }
}
