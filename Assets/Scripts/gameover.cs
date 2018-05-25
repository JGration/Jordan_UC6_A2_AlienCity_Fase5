using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour {

    public bool gameoverOn;
    public Image img;

	// Use this for initialization
	void Start () {
        img.enabled = false;
        gameoverOn = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (Lives.livesvalue == -1)
        {
            img.enabled = true;
            gameoverOn = true;
            if (Input.GetKeyDown(KeyCode.R))
            {
                Lives.livesvalue += 3;
                Lives.vida = 100;
                img.enabled = false;
                gameoverOn = false;
                SceneManager.LoadScene("Jogo");
            }
        }
    }
}
