using UnityEngine;
using System.Collections;
public class cloudspawn2 : MonoBehaviour
{
    private void Start()
    {

        StartCoroutine(Wait(1f));


    }

    private IEnumerator Wait(float seconds)
    {

        yield return new WaitForSeconds(seconds);
        gameObject.GetComponent<BoxCollider2D>().enabled = true;
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
    }

}