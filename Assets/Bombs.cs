using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombs : MonoBehaviour
{
    public GameObject bomb;
    void Start()
    {
        Actions.detonate += explodeBomb;
        Actions.interact += pickup;
    }
    void pickup()
    {

    }
    void explodeBomb()
    {
        bomb.SetActive(false);
    }
}
