using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    public Animator anim;

    public float jumpPower = 5f;
    public Transform startPos;
    private void Start()
    {        
        rb = GetComponent<Rigidbody>();
        rb.detectCollisions = true;
        transform.position = startPos.position;
        transform.rotation = startPos.rotation;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }
    }

    public void OnAir()
    {
        anim.enabled = false;
        //rb.detectCollisions = true;
        //rb.useGravity = true;
        rb.AddForce((Vector3.up * jumpPower), ForceMode.Impulse);        
    }
}
