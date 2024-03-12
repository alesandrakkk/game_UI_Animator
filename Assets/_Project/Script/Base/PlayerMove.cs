using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerMove : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool("Run",true);
        }
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("Run", false);
        }
    }
}
