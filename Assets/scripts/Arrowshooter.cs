using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrowshooter : MonoBehaviour
{
    [SerializeField] float anglerate=80;
    bool ismovingtowardsright =true;
    void Start()
    {
        
    }
    void Update()
    {
        if(ismovingtowardsright){
        transform.Rotate(new Vector3(0,0,anglerate*Time.deltaTime));
        }else{
        transform.Rotate(new Vector3(0,0,-anglerate*Time.deltaTime));
        }
        float x = transform.rotation.z;
        if(x>0.5){
            ismovingtowardsright=false;
        }else if(x<-0.5){
            ismovingtowardsright =true;
        }
    }
}
