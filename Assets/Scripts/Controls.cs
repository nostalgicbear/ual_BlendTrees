using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour {
    private Animator anim;
    private float speed = 5.0f;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        var vertical = Input.GetAxis("Vertical");



       // transform.position += (Vector3.forward * speed) * vertical * Time.deltaTime;
        anim.SetFloat("Move", vertical);

    }
}
