using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float movespeed =80;
    [SerializeField] Transform pivot;
    Rigidbody2D rb;
    [SerializeField] GameObject bullet;
    void Start(){
  
    }
    void Update(){
        if(Input.GetMouseButtonDown(0)){
        GameObject ins =Instantiate(bullet,transform.position,quaternion.identity);
        Vector3 direc= (this.transform.position-pivot.position).normalized;
        ins.transform.rotation=this.transform.rotation;
        Rigidbody2D rb= ins.GetComponent<Rigidbody2D>();
        rb.velocity=new Vector2(direc.x,direc.y).normalized*movespeed;
        }
    }
}