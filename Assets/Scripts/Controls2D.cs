using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls2D : MonoBehaviour
{
    private Animator anim;
    private float speed = 5.0f;
    public float forwardSpeed;

    public float sidewaysSpeed;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
      //  var vertical = Input.GetAxis("Vertical");
       // var horizontal = Input.GetAxis("Horizontal");



        anim.SetFloat("speedVertical", forwardSpeed, 1f, Time.deltaTime * 10f);
        anim.SetFloat("speedHorizontal", sidewaysSpeed, 1f, Time.deltaTime * 10f);
    }
}
