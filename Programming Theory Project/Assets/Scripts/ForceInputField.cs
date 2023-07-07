using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI; // Required when Using UI elements.
using TMPro;

public class ForceInputField : MonoBehaviour
{
    //public static ForceInputField Instance;
    public TMP_InputField mainInputField;
    //public String imputedNumber;
    
    public void Start()
    {
        // Sets the MyValidate method to invoke after the input field's default input validation invoke (default validation happens every time a character is entered into the text field.)
        mainInputField.onValidateInput += delegate(string input, int charIndex, char addedChar) { return MyValidate(addedChar); };
    }

    private char MyValidate(char charToValidate)
    {
        
        /*
        //Checks if a dollar sign is entered....
        if (charToValidate == '$')
        {
            // ... if it is change it to an empty character.
            charToValidate = '\0';
        }
        */
        //Checks if a dollar sign is entered....
        //('1' || '2' || '3' || '4' || '5' || '6' || '7' || '8' || '9' || '0' || '.')
        /*
        if (charToValidate != '1' || charToValidate != '2' || charToValidate != '3')
        {
            // ... if it is change it to an empty character.
            charToValidate = '\0';
        }
        else if (charToValidate != '4' || charToValidate != '5' || charToValidate != '6')
        {
            // ... if it is change it to an empty character.
            charToValidate = '\0';
        }
        else if (charToValidate != '7' || charToValidate != '8' || charToValidate != '9')
        {
            // ... if it is change it to an empty character.
            charToValidate = '\0';
        }
        else if (charToValidate != '0')
        {
            // ... if it is change it to an empty character.
            charToValidate = '\0';
        }
        */
        /*
        if(numbers.Contains(charToValidate)){
            // ... if it is change it to an empty character.
            charToValidate = '\0';
        }*/


        //return charToValidate;
        /*
        if (charToValidate == '1' || charToValidate == '2' || charToValidate = '3')
        {
            // ... if it is change it to an empty character.
            charToValidate = '\0';
        }
        */
        if (charToValidate != '1' && charToValidate != '2' &&
        charToValidate != '3' && charToValidate != '4' &&
        charToValidate != '5' && charToValidate != '6' &&
        charToValidate != '7' && charToValidate != '8' &&
        charToValidate != '9' && charToValidate != '0'
        )
        {
            // ... if it is change it to an empty character.
            charToValidate = '\0';
        }
        /*
        if (charToValidate != '2')
        {
            // ... if it is change it to an empty character.
            charToValidate = '\0';
        }
        */
        return charToValidate;


    }
    /*
    public static ForceInputField Instance {
        get {return mainInputField.text;} 
        private set {mainInputField.text = value;} 
    }
    */
}
