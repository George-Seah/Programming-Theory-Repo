using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using TMPro;
public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField NameField;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenMain(){
        SceneManager.LoadScene(1);
    }
}