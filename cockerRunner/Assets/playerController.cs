using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 10f;
    public float jumpForce = 100f;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
            Vector3 moveTowards = transform.forward * Time.fixedDeltaTime * speed;

            rb.MovePosition(rb.position + moveTowards);
    }
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        { 
            rb.AddForce(0,300,0);
        }
    }
}
