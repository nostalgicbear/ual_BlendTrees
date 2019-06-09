using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsNoBlend : MonoBehaviour
{
    private Animator anim;
    private float speed = 5.0f;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            anim.SetTrigger("walk");
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            anim.SetTrigger("walkBackwards");

        }

        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.SetTrigger("strafeLeft");

        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.SetTrigger("strafeRight");

        }
        //else {
        //    anim.SetTrigger("idle");

        //}
    }
}
