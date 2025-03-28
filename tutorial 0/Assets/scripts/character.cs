using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour
{

    private Animator _animator;
    private Rigidbody _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        _animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
         _animator.SetTrigger("walk");
         _animator.ResetTrigger("idle");
         _animator.ResetTrigger("dance");
         _animator.ResetTrigger("walkR");
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
         _animator.SetTrigger("walkR");
         _animator.ResetTrigger("idle");
         _animator.ResetTrigger("dance");
         _animator.ResetTrigger("walk");
        }
        else if (Input.GetKey(KeyCode.E))
        {
          _animator.ResetTrigger("idle");
          _animator.SetTrigger("dance");
          _animator.ResetTrigger("walkR");
          _animator.ResetTrigger("walk");
        }
        else {
          _animator.SetTrigger("idle");
          _animator.ResetTrigger("walkR");
          _animator.ResetTrigger("walk");
          _animator.ResetTrigger("dance");
        }
    }
}
