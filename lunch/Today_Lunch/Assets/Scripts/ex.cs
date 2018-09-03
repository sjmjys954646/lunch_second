using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex : MonoBehaviour {

    public GameObject ma;
    public Animator anim;

	void Start () {

        anim = ma.GetComponent<Animator>();
	}
	
    public void animgo()
    {
        anim.SetBool("start", true);
    }
	
}
