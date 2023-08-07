using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
//using Math;

public class PlayerBehavior : MonoBehaviour
{
    //public static PlayerBehavior Instance { get; private set; }
    public GameObject[] throws;
    //public int selection;
    public float horizontalInput;
    //[SerializeField] private int m_selection = 1;
    private float m_selection = 0;
    public Vector3 spawnPosition;
    public GameObject ForceInputField;
    public String imputedNumber;
    public TextMeshProUGUI guideText;
    public int convertedNumber;
    public bool forceSelectMode = false;
    public static bool projectileLaunched = false;
    public int force;
    //ENCAPCULATION
    public float selection {
        get{
            return m_selection;
        }
        set{
            if(value > 4){
                m_selection = 0;
            }
            else if(value < 0){
                m_selection = 4;
            }
            else{
                m_selection = value;
            }
        }
    }
    [SerializeField] int RoundedAnswer;
    public GameObject MainCamera;
    // ABSTRACTION
    public void InputFieldUpdated(){
        imputedNumber = ForceInputField.GetComponent<TMP_InputField>().text;
        Debug.Log(imputedNumber);
        //force = Int32.Parse(imputedNumber);
        force = (Convert.ToInt32(imputedNumber));
    }
    public void ActivateForceSelect(){
            Debug.Log("SPACE is pressed");
            Debug.Log($"Selection: {selection}, m_selection: ${m_selection}");
            RoundedAnswer = (int)Math.Floor(selection);
            //throws[RoundedAnswer].transform.position = transform.position + new Vector3(0, 0, 1);
            spawnPosition = transform.position + new Vector3(0, 0, 1);
            forceSelectMode = true;
            //Instantiate(throws[RoundedAnswer], spawnPosition, throws[RoundedAnswer].transform.rotation);
    }
    public void DeactivateForceSelect(){
        forceSelectMode = false;
    }
    public void Launch(){
        forceSelectMode = false;
        projectileLaunched = true;
        //MainCamera.SetActive(false);
        MainCamera.GetComponent<ProjectileFollower>().enabled = true;
        Instantiate(throws[RoundedAnswer], spawnPosition, throws[RoundedAnswer].transform.rotation);
    }
    // Start is called before the first frame update
    void Start()
    {
        //ForceInputField = GameObject.Find("ForceInputField");
        imputedNumber = ForceInputField.GetComponent<TMP_InputField>().text;
        Debug.Log(imputedNumber);
        MainCamera.GetComponent<ProjectileFollower>().enabled = false;
        //force = Int32.Parse(imputedNumber);
        //force = Int32.Parse("-189");

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        /*
        if(AddEventListener.KeyDown){

        }
        */
        selection += Time.deltaTime * horizontalInput;
        if(force > 100){
            force = 100;
        }
        if(Input.GetKeyDown(KeyCode.Space) && !forceSelectMode){
            ActivateForceSelect();
        }
        if(Input.GetKeyUp(KeyCode.Space)){
            //Math.Ceiling(selection);
            Debug.Log("SPACE is released");
            Debug.Log($"Selection: {selection}, m_selection: ${m_selection}");

        }
        if(forceSelectMode){
            ForceInputField.SetActive(true);
            if(!projectileLaunched){
                guideText.text = "Input a number between 0 and 101. Imputting anything more than 100 will result in the value being 100.";
            }
            
        }
        else{
            ForceInputField.SetActive(false);
            if(projectileLaunched){
                guideText.text = "Projectile is launched!";
            }
        }
        if(!forceSelectMode && !projectileLaunched){
            guideText.text = "Use A and D or the left and right arrow keys to select your projectile. Then use SPACE to open the launch speed field.";
        }
        /*

        switch(selection){
            case (selection > 0 && selection < 2.5):

            break;
        }
        */

    }
}
