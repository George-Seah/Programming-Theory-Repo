using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.IO;
using TMPro;

public class HighscoreTracker : MonoBehaviour
{
    //public static HighscoreTracker Instance;

    public String PlayerName;
    public float Score;
    public String Projectile;
    public int ProjectileForce;

    public String HighscoreName;
    public float Highscore;
    public String HighscoreProjectile;
    public int HighscoreProjectileForce;

    //private float newScore;/////

    private void Awake(){
        if(Instance != null){
            Destroy(gameObject);
            return;
        }

        
        //Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadName();
    }

    [System.Serializable]
    class SaveData{
        public String HighscoreName;
        public float Highscore;
        public String HighscoreProjectile;
        public int HighscoreProjectileForce;   
    }

    public void SaveName(float newScore, int force){
        SaveData data = new SaveData();
        data.HighscoreName = PlayerName;
        data.Highscore = newScore;/////
        data.HighscoreProjectile = GameObject.Find("Object Selection").GetComponent<TextMeshProUGUI>().text;/////
        data.HighscoreProjectileForce = force;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
        Debug.Log("Saved highscore with this name: " + HighscoreName + ", and this highscore: " + Highscore);
    }

    public void LoadName(){
        string path = Application.persistentDataPath + "/savefile.json";
        if(File.Exists(path)){
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            HighscoreName = data.HighscoreName;
            Highscore = data.Highscore;
            HighscoreProjectile = data.HighscoreProjectile;
            HighscoreProjectileForce = data.HighscoreProjectileForce;
        }
        //Debug.Log("Loaded with this name selected: " + HighscoreName + ", and this highscore: " + Highscore);
    }

    public void ResetHighscore(){
        SaveData data = new SaveData();
        data.HighscoreName = " ";
        data.Highscore = 0;/////
        data.HighscoreProjectile = null;/////
        data.HighscoreProjectileForce = 0;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
        Debug.Log("Saved highscore with this name: " + HighscoreName + ", and this highscore: " + Highscore);
    }
    public static HighscoreTracker Instance { get; private set; } // add getter to the end of the line
}
