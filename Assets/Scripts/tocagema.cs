using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tocagema : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            pedras.pedra += 1;
            pedras.scorepedra += 1;
            Destroy(gameObject);
        }
    }
}
