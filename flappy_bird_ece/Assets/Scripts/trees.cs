using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trees : MonoBehaviour
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
