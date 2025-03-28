using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Animator))]
[RequireComponent (typeof(Rigidbody))]
public class script : MonoBehaviour
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
      if (Input.GetKey(KeyCode.UpArrow))  
      {
        _animator.ResetTrigger("idle");
        _animator.SetTrigger("dance");
      }
    }
}
