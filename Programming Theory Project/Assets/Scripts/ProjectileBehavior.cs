using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    private Rigidbody Rb;
    private Vector3 force;
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
        //force = (0, 50, PlayerBehavior.force);
        force = new Vector3(0, 50, 50);
        Rb.AddForce(force, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
