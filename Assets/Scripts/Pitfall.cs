using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pitfall : MonoBehaviour {


    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
