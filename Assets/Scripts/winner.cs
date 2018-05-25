using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winner : MonoBehaviour {

    public static bool win;
    void Start()
    {
        win = false;
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            win = true;
        }
    }
}
