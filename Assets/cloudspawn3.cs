using UnityEngine;
using System.Collections;
public class cloudspawn3 : MonoBehaviour
{
    private void Start()
    {

        StartCoroutine(Wait(2f));


    }

    private IEnumerator Wait(float seconds)
    {

        yield return new WaitForSeconds(seconds);
        gameObject.GetComponent<BoxCollider2D>().enabled = true;
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
    }

}