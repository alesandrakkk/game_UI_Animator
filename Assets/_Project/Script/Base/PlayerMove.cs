using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerMove : MonoBehaviour
{
    private Animator animator;

    private Vector2 inputDirection;

    private const string HorizontalAxisName = "Horizontal";

    private const string VerticallAxisName = "Vertical";

    private const string MoveForvard = "MoveValue";


    private void Awake() {
        animator = GetComponent<Animator>();
    }


    private void Update() {
        inputDirection = new Vector2(Input.GetAxis(HorizontalAxisName),  Input.GetAxis(VerticallAxisName));

        animator.SetFloat(MoveForvard, inputDirection.y);
    }
}
