using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
public class bosstext : MonoBehaviour
{
    public float MaxAngle = 25;
    public float minAngle = -25;
    private float destroy;

    public GameObject Fireball;
   
    void Start()
    {
        destroy = 5;
        StartCoroutine(Wait(destroy));
        
    }

    // Update is called once per frame



    IEnumerator Wait(float sec)
    {
       
       
        {
            yield return new WaitForSeconds(sec);

            destroy = 5;
            Destroy(gameObject);

            
        }
    }





}