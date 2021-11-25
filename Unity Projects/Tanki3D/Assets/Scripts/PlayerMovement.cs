using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    public float baseSpeed;
    public float turnSpeed;
    public float breakSpeed;
    public Vector3 movement;
    void Start()
    {
        rb = transform.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //rb.AddForce(transform.forward * -1 * baseSpeed, ForceMode.Force);
            rb.MovePosition(transform.position + transform.forward * -baseSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //rb.AddForce(transform.forward * baseSpeed, ForceMode.Force);
            rb.MovePosition(transform.position + transform.forward * baseSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0.0f, turnSpeed, 0.0f, Space.Self);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0.0f, -turnSpeed, 0.0f, Space.Self);
        }
    }
}
