using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trap1 : MonoBehaviour {


    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            Lives.livesvalue -= 1;
            Destroy(col.gameObject);
            SceneManager.LoadScene("Jogo");
        }
    }
}
