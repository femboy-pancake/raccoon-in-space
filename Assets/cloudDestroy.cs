using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class cloudDestroy : MonoBehaviour
{
    BoxCollider2D Thunderbolt;
    private float destroy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Thunderbolt = GetComponent<BoxCollider2D>();


        if (Thunderbolt != null)
        {
           Thunderbolt.enabled = true;
        }



        Destroy(gameObject, 2.9f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
}
