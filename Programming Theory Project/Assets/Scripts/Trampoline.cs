using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    protected Collider coll;
    protected float dynFriction;
    protected float bounciness = 0.5f;
    protected float statFriction;

    protected float startZ;

    public float backwardMax;
    public float forwardMax;
    protected float speed = 2.5f;
    /*
    public float _forwardMax;
    public float forwardMax{
        get{
            return _forwardMax;
        }
        set{
            if(value > (startZ + value)){
                Debug.Log("Value is suitable");
                _forwardMax = value;
            }
            else{
                Debug.Log("Max value is supposed to go over Max value + startZ");
            }
        }
    }
    */
    public void MaxValueCheckers(){
        if(forwardMax >= startZ){
            Debug.Log("forwardMax Value is suitable");
        }
        else{
            //Debug.Log("Max value is supposed to go over Max value + startZ");
            Debug.LogError("Max value is supposed to go over startZ");
        }
        if(backwardMax <= startZ){
            Debug.Log("backwardMax Value is suitable");
        }
        else{
            //Debug.Log("Max value is supposed to go over Max value + startZ");
            Debug.LogError("backwardMax value is supposed to go under startZ");
        }
    }
    public void Barriers(){
        if((transform.position.z > forwardMax) || (transform.position.z < backwardMax)){
            speed *= -1;
        }
    }
    public void Move(){
        transform.position += new Vector3(0, 0, speed * Time.deltaTime);
    }
    // Start is called before the first frame update
    void Start()
    {
        coll = GetComponent<Collider>();
        bounciness = 0.5f;
        startZ = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        coll.material.dynamicFriction = dynFriction;
        coll.material.staticFriction = statFriction;
        coll.material.bounciness = bounciness;

        //Error throwers
        MaxValueCheckers();
        //Barrier functions
        Barriers();
        //Trampoline mover function
        Move();
        
    }
}
