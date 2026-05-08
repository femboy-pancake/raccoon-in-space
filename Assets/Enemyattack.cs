
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
public class Enemyattack : MonoBehaviour
{
     
   private float attack;
    
   public GameObject thunderbolt;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        attack = Random.Range(5, 7);
        StartCoroutine(Wait(attack));
        
    }

    // Update is called once per frame
    

    
    IEnumerator Wait(float sec)
    {
        //while Boss is alive, repeat attack between 5 and 10 seconds
        while (true)
        {
        yield return new WaitForSeconds(sec);
            
        attack = Random.Range(5, 7);
        Instantiate(thunderbolt, new Vector3(Random.Range(-12.93f, -0.63f), -0.36f, 0), Quaternion.identity);

        }
    }


    


}
