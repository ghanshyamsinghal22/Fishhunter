using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
public class UIgameOver : MonoBehaviour
{
    [SerializeField] Data data;
    [SerializeField] TextMeshProUGUI tmpscore;
    void Update(){
        tmpscore.text="score :"+data.score.ToString();
    }
}