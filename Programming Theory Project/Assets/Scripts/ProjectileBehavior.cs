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
    
    private GameObject Canvas;
    
    private GameObject HighscoreTracker;
    [SerializeField] private float Score;

    private bool distanceChangeable = true;
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
        Canvas = GameObject.Find("Canvas");

        //force = (0, 50, PlayerBehavior.force);
        force = new Vector3(0, 10, zForce);
        Rb.AddForce(force, ForceMode.Impulse);
        distanceTravelled = GameObject.Find("Distance Travelled");
        distanceTravelledText = distanceTravelled.GetComponent<TextMeshProUGUI>().text;

        HighscoreTracker = GameObject.Find("Highscore Tracker");
    }

    // Update is called once per frame
    void Update()
    {
        
        if(distanceChangeable){
            distanceTravelled.GetComponent<TextMeshProUGUI>().text = $"Distance travelled: {transform.position.z}";
            Canvas.GetComponent<GameUIHandler>().Score = transform.position.z;
            
            Score = transform.position.z;

            
            if(Score > HighscoreTracker.GetComponent<HighscoreTracker>().Highscore){
                HighscoreTracker.GetComponent<HighscoreTracker>().SaveName(Score, zForce);
            }
            
        }
        if(grounded || transform.position.y < 0){
            distanceChangeable = false;
        }
        
    }
}
