
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
public class burger_spawner : MonoBehaviour
{
    public Birdy BirdScript;
    public GameObject Burgers;
    //public float height;
    public float time;

    void Start()
    {
        StartCoroutine(SpawnObject(time));
    }


    public IEnumerator SpawnObject(float time)
    {
        while (!BirdScript.isDead)
        {
            yield return new WaitForSeconds(time);
            Instantiate(Burgers, new Vector3(3, Random.Range(0.03f, 0.10f), 0), Quaternion.identity);
            //yield return new WaitForSeconds(time);



        }

    }
}
