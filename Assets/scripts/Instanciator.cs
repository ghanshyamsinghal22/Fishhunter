using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Instanciator : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] List<GameObject> l;
    [SerializeField] Data data;
    [SerializeField] GameObject fish;
    void Start()
    {
        StartCoroutine(generate());
    }

    void Update()
    {
        
    }
    IEnumerator generate(){
        while(true){
            int r= Random.Range(0,l.Count);
            Instantiate(fish,l[r].transform);
            Debug.Log(data.timer);
            
            if(data.timer<=0){
                SceneManager.LoadScene("gameover");
            }
            data.timer--;
            yield return new WaitForSeconds(1);
        }
    }
}
