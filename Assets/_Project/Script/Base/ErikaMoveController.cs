using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class ErikaMoveController : MonoBehaviour
{
    private Animator animator;

    [SerializeField] private AudioSource _audio;
    [SerializeField] private ParticleSystem _dust;

    private Vector2 _direction;

    private const string HorizontalAxis = "Horizontal";
    private const string VerticalAxis = "Vertical";
    private const string Movement = "MovementSpeed";
    private const string Celebrate = "Celebrate";

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }


    private void Update()
    {
        _direction = new Vector2(Input.GetAxis(HorizontalAxis), Input.GetAxis(VerticalAxis));
              
        animator.SetFloat(Movement, _direction.y);
        animator.SetFloat("Vertical", _direction.y);
        animator.SetFloat("Horizontal", _direction.x);

        if (Input.GetKeyDown(KeyCode.C))
        {
            animator.SetBool(Celebrate, true);
        }
        if (Input.GetKeyUp(KeyCode.C))
        {
            animator.SetBool(Celebrate, false);
        }
                
    }

    private void PlaySoundAndDust()
    {
        Debug.Log("Go");

        _dust.Play();
    }
}
