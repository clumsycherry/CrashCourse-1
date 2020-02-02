using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityOn : MonoBehaviour
{
    /*public Rigidbody rb; //= GetComponent<Rigidbody>(); 
    float gravity = -9.8f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    } */
    Animator anim; 
    void Start(){
        anim = GetComponent<Animator>(); 
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("PhoneDrop");
            //GetComponent<Rigidbody>().useGravity = true;
            //GetComponent<Rigidbody>() = new Vector3(rb.velocity.x, rb.velocity.y +gravity * Time.deltaTime,rb.velocity.z );
            //GetComponent<Rigidbody>().isKinematic = false;
            //Debug.Log("hello");
        }
    }
}
