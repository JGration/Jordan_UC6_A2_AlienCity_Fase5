using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lives : MonoBehaviour {

    public static int livesvalue = 2;
    public static int vida = 100;
    public Text lives;

    void Start()
    {
        lives = GetComponent<Text>();
    }
    void Update()
    {
        lives.text = "x" + livesvalue;
        if(vida < 0)
        {
            livesvalue -= 1;
            SceneManager.LoadScene("Jogo");
            vida = 100;
        }
    }
}
