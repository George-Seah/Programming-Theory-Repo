using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UltraTrampoline : Trampoline
{
    public UltraTrampoline()
    {
        Debug.Log("1st UltraTrampoline Constructor Called");
    }
    /*
    public UltraTrampoline(string newColor) : base(newColor)
    {
        //Notice how this constructor doesn't set the color
        //since the base constructor sets the color that
        //is passed as an argument.
        Debug.Log("2nd Apple Constructor Called");
    }
    */
    // Start is called before the first frame update
    void Awake()
    {
        bounciness = 1f;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
