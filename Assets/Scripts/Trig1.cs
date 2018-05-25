using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trig1 : MonoBehaviour {

    public int trigger1 = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            trigger1 = 1;
        }
    }
}
