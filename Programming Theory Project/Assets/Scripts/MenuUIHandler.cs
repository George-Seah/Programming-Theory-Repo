using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField NameField;
    public String PlayerName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NameChanged(){
        //PlayerNameText = NameField.GetComponent<TextMeshProUGUI>().text;
        PlayerName = NameField.GetComponent<TMP_InputField>().text;
        HighscoreTracker.Instance.PlayerName = PlayerName;
    }

    public void OpenMain(){
        SceneManager.LoadScene(1);
    }
    public void Exit(){
        //MainManager.Instance.SaveColor();
        #if UNITY_EDITOR
                EditorApplication.ExitPlaymode();
        #else
                Application.Quit(); // original code to quit Unity player
        #endif
    }
}
