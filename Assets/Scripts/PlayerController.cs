using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    public Animator anim;

    private bool onAir;
    private bool spinning;
    public float rotationSpeed;

    public float jumpPower = 5f;

    public UI ui;
    public float trickScore;
    public float score;

    private void Start()
    {        
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            spinning = true;
        }
        else
            spinning = false;
    }

    private void FixedUpdate()
    {     
        if (onAir)
        {
            if (transform.position.y < 12)
            {
                onAir = false;
                anim.enabled = true;
                score += trickScore;
                trickScore = 0;
                ui.UpdateScore();
            }
            else if (spinning)
            {                
                transform.Rotate(0, rotationSpeed, 0);
                trickScore += (int)rotationSpeed;
                ui.UpdateTrickScore();
            }
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
