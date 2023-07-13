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
    public float m_selection = 1;
    public Vector3 spawnPosition;
    public GameObject ForceInputField;
    public String imputedNumber;
    public int convertedNumber;
    public bool forceSelectMode = false;
    public int force;
    public float selection {
        get{
            return m_selection;
        }
        set{
            if(value > 4){
                value = 0;
            }
            else if(value < 0){
                value = 4;
            }
            else{
                m_selection = value;
            }
        }
    }
    [SerializeField] int RoundedAnswer;

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
        Instantiate(throws[RoundedAnswer], spawnPosition, throws[RoundedAnswer].transform.rotation);
    }
    // Start is called before the first frame update
    void Start()
    {
        //ForceInputField = GameObject.Find("ForceInputField");
        imputedNumber = ForceInputField.GetComponent<TMP_InputField>().text;
        Debug.Log(imputedNumber);
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

        if(Input.GetKeyDown(KeyCode.Space) && !forceSelectMode){
            ActivateForceSelect();
        }
        if(Input.GetKeyUp(KeyCode.Space)){
            Math.Ceiling(selection);
            Debug.Log("SPACE is released");
            Debug.Log($"Selection: {selection}, m_selection: ${m_selection}");

        }
        if(forceSelectMode){
            ForceInputField.SetActive(true);
        }
        else{
            ForceInputField.SetActive(false);        
        }
        /*

        switch(selection){
            case (selection > 0 && selection < 2.5):

            break;
        }
        */

    }
}
