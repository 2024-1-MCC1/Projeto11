using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpHeight = 3;
    void Update()
    {


        if (Input.GetMouseButtonDown(0))
            rb.velocity = new Vector3(0, jumpHeight, 0);

    }
}
