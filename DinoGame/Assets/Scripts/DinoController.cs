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
        if (currentZSpeed == 0 && currentXSpeed == 0) {
            anim.SetFloat("Speed", 0);
        }
        if (currentZSpeed > 0) {
            if (!(this.transform.rotation.eulerAngles == new Vector3(0, 0, 0))) {
                this.transform.rotation = Quaternion.identity;
            }
            anim.SetFloat("Speed", currentZSpeed * speed);
        }
        if (currentZSpeed < 0)
        {
            if (!(this.transform.rotation.eulerAngles == new Vector3(0, 180, 0)))
            {
                this.transform.Rotate(new Vector3(0, this.transform.rotation.eulerAngles.y + 180, 0));
            }
            anim.SetFloat("Speed", -currentZSpeed * speed);
        }
        transform.Translate(new Vector3(0, 0, currentXSpeed));
    }
}
