using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Addtorque : MonoBehaviour
{
    public float AngularSpeed;
    public float speed;
    protected Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {

        speed = rb.velocity.magnitude;
        AngularSpeed = rb.angularVelocity.magnitude;


        rb.maxAngularVelocity = float.MaxValue;


        rb.AddTorque(Vector3.up);
            

    }
}
