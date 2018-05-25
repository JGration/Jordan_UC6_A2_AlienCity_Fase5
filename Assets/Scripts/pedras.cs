using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pedras : MonoBehaviour {

    public static int pedra = 0;
    public static int scorepedra = 0;
    public Image img;
    public Sprite pedra1;
    public Sprite pedra2;
    public Sprite pedra3;

    void Start () {
        img = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		if(pedra == 1)
        {
            this.GetComponent<Image>().overrideSprite = pedra1;
        }
        if (pedra == 2)
        {
            this.GetComponent<Image>().overrideSprite = pedra2;
        }
        if (pedra == 3)
        {
            this.GetComponent<Image>().overrideSprite = pedra3;
        }
    }
}
