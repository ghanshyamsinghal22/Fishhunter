using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectors : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D other){
        Destroy(other.gameObject);
    }
}
