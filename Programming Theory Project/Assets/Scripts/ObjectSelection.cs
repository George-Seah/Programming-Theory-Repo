using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
public class ObjectSelection : MonoBehaviour
{
    private GameObject Player;
    [SerializeField] private float selection;
    [SerializeField] private int RoundedSelection;
    [SerializeField] private TextMeshProUGUI TextMesh;
    [SerializeField] private String SelectionText;
    public void selectionChanged(){
        selection = Player.GetComponent<PlayerBehavior>().selection;
        RoundedSelection = (int)Math.Floor(selection);
    }
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        SelectionText = GetComponent<TextMeshProUGUI>().text;
        TextMesh = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Horizontal") != 0){
            selectionChanged();
        }
        //if(Input.GetKeyDown(KeyCode.Space)){

            switch(RoundedSelection){
                case 0:
                    //SelectionText = "Regular Cube";
                    TextMesh.text = "Regular Cube";
                break;
            }
            switch(RoundedSelection){
                case 1:
                    //SelectionText = "Regular Cube";
                    TextMesh.text = "Regular Sphere";
                break;
            }
            switch(RoundedSelection){
                case 2:
                    //SelectionText = "Regular Cube";
                    TextMesh.text = "Bouncy Cube";
                break;
            }
            switch(RoundedSelection){
                case 3:
                    //SelectionText = "Regular Cube";
                    TextMesh.text = "Bouncy Sphere";
                break;
            }
        //}

    }
}
