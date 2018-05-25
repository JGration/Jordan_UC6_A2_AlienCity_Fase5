using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

    public static int scorevalue = 0;
    public Text scoring;


	void Start () {
        scoring = GetComponent<Text>();
	}
	
	void Update () {
        scoring.text = "Score: " + scorevalue;
        if (Keys.scorekey1 == 1)
        {
            scorevalue += 100;
            Keys.scorekey1 = 0;
        }
        if (Keys2.scorekey2 == 1)
        {
            scorevalue += 100;
            Keys2.scorekey2 = 0;
        }
        if (pedras.scorepedra == 1)
        {
            scorevalue += 300;
            pedras.scorepedra = 0;
        }
    }
}
