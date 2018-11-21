using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoController : MonoBehaviour {
    Animator anim;
    public float speed = 10;

	// Use this for initialization
	void Start () {
        anim = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        float walkSpeed = Input.GetAxis("Vertical") *speed;
        anim.SetFloat("Speed", walkSpeed);
        transform.Translate(0, 0, walkSpeed * Time.deltaTime);
	}
}
