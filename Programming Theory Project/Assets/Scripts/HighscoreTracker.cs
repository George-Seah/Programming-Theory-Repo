using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.IO;

public class HighscoreTracker : MonoBehaviour
{
    public static HighscoreTracker Instance;

    public String PlayerName;
    public int Score;
    
    public String HighscoreName;
    public int Highscore;


    private void Awake(){
        if(Instance != null){
            Destroy(gameObject);
            return;
        }

        
        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadName();
    }

    [System.Serializable]
    class SaveData{
        public String HighscoreName;
        public int Highscore;
    }

    public void SaveName(){
        SaveData data = new SaveData();
        data.HighscoreName = PlayerName;
        data.Highscore = Score;
        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
        //Debug.Log("Saved highscore with this name: " + HighscoreName + ", and this highscore: " + Highscore);
    }

    public void LoadName(){
        string path = Application.persistentDataPath + "/savefile.json";
        if(File.Exists(path)){
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            HighscoreName = data.HighscoreName;
            Highscore = data.Highscore;
        }
        //Debug.Log("Loaded with this name selected: " + HighscoreName + ", and this highscore: " + Highscore);
    }
}
