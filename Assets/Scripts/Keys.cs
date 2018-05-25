using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keys : MonoBehaviour {

    public int abreportao = 0;
    public static bool keygreen;
    public static int scorekey1 = 0;

    void Start()
    {
        keygreen = false;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            keygreen = true;
            Destroy(gameObject);
            abreportao = 1;
            scorekey1 = 1;
        }
    }
}
