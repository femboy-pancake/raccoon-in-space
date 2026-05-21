using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
public class fireball2 : MonoBehaviour
{
    public float MaxAngle = 25;
    public float minAngle = -25;
    private float attack;

    public GameObject Fireball;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        attack = Random.Range(3, 4);
        StartCoroutine(Wait(attack));

    }

    // Update is called once per frame



    IEnumerator Wait(float sec)
    {
        //while Boss is alive, repeat attack between 5 and 10 seconds
        while (true)
        {
            yield return new WaitForSeconds(sec);

            attack = Random.Range(3, 4);
            Instantiate(Fireball, new Vector3(-17.23f, 4.46f, 0f), Quaternion.Euler(new Vector3(0, 0, Random.Range(MaxAngle = -4.7f, minAngle = -40.59f))));

            //(Random.Range(4.44f, -3.95f)), 0f), Quaternion.identity);
        }
    }





}
