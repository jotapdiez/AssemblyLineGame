using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Seller : MonoBehaviour
{

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter2D(Collider2D target)
    {
        PrimitiveResource sourceType = target.gameObject.GetComponent<Resource>().GetResourceType();
        //Money++
        Destroy(target.gameObject);
    }
}
