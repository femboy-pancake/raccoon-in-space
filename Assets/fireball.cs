
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
public class fireball : MonoBehaviour
{

    private float attack;

    public GameObject Fireball;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        attack = Random.Range(10, 12);
        StartCoroutine(Wait(attack));

    }

    // Update is called once per frame



    IEnumerator Wait(float sec)
    {
        //while Boss is alive, repeat attack between 5 and 10 seconds
        while (true)
        {
            yield return new WaitForSeconds(sec);

            attack = Random.Range(5, 7);                  // fix so he moves on the x axes
            Instantiate(Fireball, new Vector3(-17.3f, (Random.Range(4.44f, -17.43f)), 0f), Quaternion.identity);

        }
    }





}
