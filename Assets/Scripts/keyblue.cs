using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keyblue : MonoBehaviour {

    public bool keyBon;
    public Image img;

    // Use this for initialization
    void Start()
    {
        img.enabled = false;
        keyBon = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Keys2.keyblue == true)
        {
            img.enabled = true;
            keyBon = true;
        }
    }
}
