using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float movespeed=30;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x =Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(x*Time.deltaTime*movespeed,0,0));
        if(transform.position.x>7.5){
            transform.position=new Vector3(7.5f,transform.position.y,transform.position.z);
        }else if(transform.position.x<-7.5){
            transform.position=new Vector3(-7.5f,transform.position.y,transform.position.z);
        }
    }
}
