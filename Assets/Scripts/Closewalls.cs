using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Closewalls : MonoBehaviour {
    
    private Animator anim;
    private Trig1 trigger1a;
    public GameObject T1;
    private int trigger2;

    void Start()
    {
        anim = GetComponent<Animator>();
        trigger1a = T1.GetComponent<Trig1>();
        trigger2 = trigger1a.trigger1;
        Debug.Log(trigger2);
    }
    void Update()
    {
        trigger1a = T1.GetComponent<Trig1>();
        trigger2 = trigger1a.trigger1;
        Debug.Log(trigger2);
        if (trigger2 == 1)
        {
            anim.SetTrigger("foundplayer");

        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            Destroy(col.gameObject);
            SceneManager.LoadScene("Jogo");
        }
    }
}