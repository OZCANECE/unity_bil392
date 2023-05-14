
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class trees_spawner : MonoBehaviour
{

    public Birdy BirdScript;
    public GameObject Agaclar;
    //public float height;
    public float time;

    void Start()
    {
        StartCoroutine(SpawnObject(time));
    }

    
    public IEnumerator SpawnObject(float time)
    {
        yield return new WaitForSeconds(2f);
        while (!BirdScript.isDead)
        {

            Instantiate(Agaclar, new Vector3(3, -0.314f), Quaternion.identity);
            yield return new WaitForSeconds(time);

            
          
        }

    }
}
