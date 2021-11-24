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
            rb.AddForce(transform.forward * -1 * baseSpeed, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(transform.forward * baseSpeed, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(transform.forward * turnSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(transform.forward * turnSpeed * Time.deltaTime * -1);
        }
    }
}
