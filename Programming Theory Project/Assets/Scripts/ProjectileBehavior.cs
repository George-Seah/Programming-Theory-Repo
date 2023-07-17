using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class ProjectileBehavior : MonoBehaviour
{
    private Rigidbody Rb;
    private Vector3 force;
    private GameObject Player;
    [SerializeField] private int zForce;
    [SerializeField] private bool grounded;
    //[SerializeField] public TextMeshProUGUI distanceTravelled;
    [SerializeField] private GameObject distanceTravelled;
    private String distanceTravelledText;
    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Ground")){
            grounded = true;
        }
        
    }
    
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
        Player = GameObject.Find("Player");
        zForce = Player.GetComponent<PlayerBehavior>().force;
        //force = (0, 50, PlayerBehavior.force);
        force = new Vector3(0, 10, zForce);
        Rb.AddForce(force, ForceMode.Impulse);
        distanceTravelled = GameObject.Find("Distance Travelled");
        distanceTravelledText = distanceTravelled.GetComponent<TextMeshProUGUI>().text;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(!grounded){
            distanceTravelled.GetComponent<TextMeshProUGUI>().text = $"Distance travelled: {transform.position.z}";
        }
        
    }
}
