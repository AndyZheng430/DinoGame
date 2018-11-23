using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoController : MonoBehaviour {
    Animator anim;
    public float speed = 5;

	// Use this for initialization
	void Start () {
        anim = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        float currentZSpeed = Input.GetAxis("Vertical");
        float currentXSpeed = Input.GetAxis("Horizontal");
        if (currentZSpeed > 0) {
            if (!(this.transform.rotation.eulerAngles == new Vector3(0, 0, 0))) {
                this.transform.Rotate(new Vector3(0, this.transform.rotation.eulerAngles.y, 0));
            }
            anim.SetFloat("Speed", currentZSpeed);
        }
        if (currentZSpeed < 0)
        {
            if (!(this.transform.rotation.eulerAngles == new Vector3(0, 180, 0)))
            {
                this.transform.Rotate(new Vector3(0, this.transform.rotation.eulerAngles.y + 180, 0));
            }
            anim.SetFloat("Speed", -currentZSpeed);
        }
        transform.Translate(new Vector3(0, 0, currentXSpeed));
    }
}
