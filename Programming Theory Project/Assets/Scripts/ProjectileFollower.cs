using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileFollower : MonoBehaviour
{
    public GameObject projectile;
    private Vector3 offset = new Vector3(0, 5, -7);
    // Start is called before the first frame update
    void Start()
    {
        projectile = GameObject.FindWithTag("Projectile");
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = projectile.transform.position + offset;
    }
}
