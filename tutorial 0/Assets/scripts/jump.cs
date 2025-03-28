using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour

{
    Rigidbody m_Rigidbody;
    private bool onFloor = false;
    public float force = 20f;
    
    
        void Start()
        {
         m_Rigidbody = GetComponent<Rigidbody>();
        }
    private void OnCollisionEnter(Collision collision)
        {
        if (collision.gameObject.tag == "floor") {
        onFloor = true;
        }
        } 
    
        void Update()
        {
            if (Input.GetKeyDown("space") && onFloor == true)
            {
                Debug.Log("jump!");
               m_Rigidbody.AddForce(transform.up * force);
                onFloor = false;
                
            }
        }
    
}
