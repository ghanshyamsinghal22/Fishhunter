using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Fish : MonoBehaviour
{
    [SerializeField] float movespeed =8;
    [SerializeField] Data data;
    void Update(){
        transform.Translate(movespeed*Time.deltaTime,0,0);
    }
    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.CompareTag("arrow"))
        {
            data.score++;
            data.timer+=3;
            Destroy(other.gameObject);
        }
        Destroy(gameObject);
    }
}
