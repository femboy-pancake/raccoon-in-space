using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class cloudDestroy : MonoBehaviour
{
    BoxCollider2D thunderbolt;
    private float destroy;
    private float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


        thunderbolt = GetComponent<BoxCollider2D>();

        thunderbolt.enabled = false;

        StartCoroutine(Wait(timer));


        Destroy(gameObject, 2.9f);
    }

    // Update is called once per frame
    IEnumerator Wait(float sec)
    {
        yield return new WaitForSeconds(1.3f);
        thunderbolt.enabled = true;
    }

}
