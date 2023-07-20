using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class GameUIHandler : MonoBehaviour
{
    //UI Variables
    public String PlayerName;
    public float Score;
    public GameObject Projectile;
    public int ProjectileForce;

    public String HighscoreName;
    public float Highscore;
    public GameObject HighscoreProjectile;
    public int HighscoreProjectileForce;

    
    public GameObject HighscoreTracker;

    //Canvas stuff
    public TextMeshProUGUI PlayerNameText;
    public TextMeshProUGUI ProjectileText;
    public TextMeshProUGUI ProjectileForceText;

    public TextMeshProUGUI HighscorePlayerNameText;
    public TextMeshProUGUI HighscoreText;
    public TextMeshProUGUI HighscoreProjectileText;
    public TextMeshProUGUI HighscoreProjectileForceText; 

    // Start is called before the first frame update
    void Start()
    {
        HighscoreTracker = GameObject.Find("Highscore Tracker");

        PlayerName = HighscoreTracker.GetComponent<HighscoreTracker>().PlayerName;
        Score = HighscoreTracker.GetComponent<HighscoreTracker>().Score;
        //Projectile = HighscoreTracker.GetComponent<HighscoreTracker>().Projectile;
        ProjectileForce = HighscoreTracker.GetComponent<HighscoreTracker>().ProjectileForce;

        HighscoreName = HighscoreTracker.GetComponent<HighscoreTracker>().HighscoreName;
        Highscore = HighscoreTracker.GetComponent<HighscoreTracker>().Highscore;
        HighscoreProjectile = HighscoreTracker.GetComponent<HighscoreTracker>().HighscoreProjectile;
        HighscoreProjectileForce = HighscoreTracker.GetComponent<HighscoreTracker>().HighscoreProjectileForce; 
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerBehavior.projectileLaunched){
            Projectile = GameObject.FindWithTag("Projectile");
        }
        
        PlayerNameText.text = $"Player name: {PlayerName}";
        ProjectileForceText.text = $"Initial projectile force: {ProjectileForce}";
        HighscorePlayerNameText.text = $"Highscore owner: {HighscoreName}";
        HighscoreText.text = $"Highscore: {Highscore}";
        HighscoreProjectileText.text = $"Highscore projectile: {HighscoreProjectile}";
        HighscoreProjectileForceText.text = $"Highscore force: {HighscoreProjectileForce}";
    }
}
