
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
public class Enemyattack : MonoBehaviour
{
    int attack = rng(5, 7);
    GameObject thunderbolt;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //between 5-10 sec make attack spawn randomly in X-angle
       
        Instantiate(thunderbolt, new Vector3(Random.Range(-8, -0.055f), 7, 0), Quaternion.identity);

    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5);
        Random rnd = new Random();
    }
}
