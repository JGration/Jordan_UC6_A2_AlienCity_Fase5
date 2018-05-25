using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keygreen : MonoBehaviour {

    public bool keyGon;
    public Image img;

    // Use this for initialization
    void Start () {
        img.enabled = false;
        keyGon = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Keys.keygreen == true)
        {
            img.enabled = true;
            keyGon = true;
        }
	}
}
