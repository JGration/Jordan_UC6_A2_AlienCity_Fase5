using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class winnerimg : MonoBehaviour {

    public bool winnerOn;
    public Image img;

    // Use this for initialization
    void Start()
    {
        img.enabled = false;
        winnerOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (winner.win == true)
        {
            img.enabled = true;
            winnerOn = true;
            if (Input.GetKeyDown(KeyCode.R))
            {
                Lives.livesvalue = 2;
                Lives.vida = 100;
                img.enabled = false;
                winnerOn = false;
                SceneManager.LoadScene("Jogo");
            }
        }
    }
}
