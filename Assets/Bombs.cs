using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombs : MonoBehaviour
{
    void Start()
    {
        Actions.detonate += explodeBomb;
    }
    void explodeBomb()
    {
        gameObject.SetActive(false);
    }
}
