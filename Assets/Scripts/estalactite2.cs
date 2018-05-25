using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class estalactite2 : MonoBehaviour {

    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            rb.isKinematic = false;
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            Lives.livesvalue -= 1;
            Destroy(col.gameObject);
            SceneManager.LoadScene("Jogo");
        }
        else
        {

            Destroy(gameObject, 2);
        }
    }
}
