using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class barravida : MonoBehaviour {

    public Image img;
    public Sprite vida40;

    void Start () {
        img = GetComponent<Image>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Lives.vida < 50)
        {
            this.GetComponent<Image>().overrideSprite = vida40;
        }
    }
}
