using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    protected Collider coll;
    protected float dynFriction;
    public float bounciness;
    protected float statFriction;
    // Start is called before the first frame update
    void Start()
    {
        coll = GetComponent<Collider>();
        bounciness = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        coll.material.dynamicFriction = dynFriction;
        coll.material.staticFriction = statFriction;
        coll.material.bounciness = bounciness;
    }
}
