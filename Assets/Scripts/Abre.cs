using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abre : MonoBehaviour {

    private Keys keysA;
    private Keys2 keysB;
    public GameObject chave1;
    public GameObject chave2;
    private int abre1;
    private int abre2;
    private Animator anim;

    void Start ()
    {
        anim = GetComponent<Animator>();
        keysA = chave1.GetComponent<Keys>();
        keysB = chave2.GetComponent<Keys2>();
        abre1 = keysA.abreportao;
        Debug.Log(abre1);
        abre2 = keysB.abreportao2;
        Debug.Log(abre2);
	}
    void Update()
    {
        abre1 = keysA.abreportao;
        Debug.Log(abre1);
        abre2 = keysB.abreportao2;
        Debug.Log(abre2);
        if (abre1 == 1 & abre2 == 1)
        {
            anim.SetTrigger("open");
        }
    }
    void OnTriggerEnter(Collider other)
    {
        
    }
}
