using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class pipes_spawner : MonoBehaviour
{
    public Birdy BirdScript;
    public GameObject Borular ;
    //public float height;
    public float time; 
    private void Start()
    {
        StartCoroutine(SpawnObject(time));
    }
  

    public IEnumerator SpawnObject(float time)
    {
       // yield return new WaitForSeconds(1f);
        while (!BirdScript.isDead) {
            
            Instantiate(Borular, new Vector3(3, Random.Range(-0.3f, 0.5f), 0), Quaternion.identity);
            yield return new WaitForSeconds(time); // 2 sn de sapwlar
        }
        
    }
}
