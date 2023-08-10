using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// INHERITANCE
public class UltraTrampoline : Trampoline
{


    //POLYMORPHISM
    void Awake()
    {
        bounciness = 1f;
        speed = 5f;
    }
    public UltraTrampoline()
    {
        Debug.Log("1st UltraTrampoline Constructor Called");
    }
    // POLYMORPHISM
    public override void Move(){
        //float speed = 15f;
        //float bounciness = 1f;
        Debug.Log("speed and bounciness of Ultra Trampoline should be different.");
        base.Move();
        //transform.position += new Vector3(0, 0, speed * Time.deltaTime);
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
    // Update is called once per frame
    
}
