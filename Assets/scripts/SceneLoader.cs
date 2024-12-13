using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] Data data;
    public void LoadGame(){
        data.score=0;
        data.timer=10;
        SceneManager.LoadScene("SampleScene");
    }
    
}
