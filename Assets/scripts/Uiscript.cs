using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Uiscript : MonoBehaviour
{
    [SerializeField] Data data;
    [SerializeField] TextMeshProUGUI tmpscore;
    [SerializeField] TextMeshProUGUI tmptime;
    void Update(){
        tmpscore.text="score :"+data.score.ToString();
        if(data.timer>=0){
        tmptime.text="Time Left :"+data.timer.ToString();
        }
    }
    
}
