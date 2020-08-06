using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    public Animator anim;

    public float rotationSpeed = 60;
    public float jumpPower = 5f;
    private bool onAir;

    private void Start()
    {        
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            rb.angularVelocity = rotationSpeed * Vector3.forward;
        }


        if(onAir && transform.position.y < 12)
        {
            anim.enabled = true;
            rb.velocity = Vector3.zero;
            onAir = false;
        }
    }

    public void OnAir()
    {
        anim.enabled = false;
        rb.velocity = Vector3.zero;
        rb.AddForce((Vector3.up * jumpPower), ForceMode.Impulse);
        onAir = true;
    }
}
