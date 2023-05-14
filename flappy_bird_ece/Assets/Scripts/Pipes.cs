using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed;
    void Start()
    {
        Destroy(gameObject, 15);
    }

    
    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
