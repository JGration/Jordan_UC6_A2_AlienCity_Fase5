using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pedratk1 : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            Lives.vida -= 60;
            Destroy(gameObject);
        }
    }
}
