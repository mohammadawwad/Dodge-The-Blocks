﻿
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardforce = 200f;
    public float sidewayforce = 100f;

    void FixedUpdate ()
    {
        rb.AddForce(0, 0, forwardforce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))       {
            rb.AddForce(-sidewayforce* Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1)


     
        {
           
        }
    }







}
