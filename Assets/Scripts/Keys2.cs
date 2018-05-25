using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keys2 : MonoBehaviour {

    public int abreportao2 = 0;
    public static int scorekey2 = 0;
    public static bool keyblue;

    void Start()
    {
        keyblue = false;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            keyblue = true;
            Destroy(gameObject);
            abreportao2 = 1;
            scorekey2 = 1;
        }
    }
}
