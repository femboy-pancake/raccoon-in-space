
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
public class bombscript : MonoBehaviour
{

    private float spawn;

    public GameObject thunderbolt;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawn = 20;
        StartCoroutine(Wait(spawn));

    }

    // Update is called once per frame



    IEnumerator Wait(float sec)
    {
        //while Boss is alive, repeat attack between 5 and 10 seconds
        
            yield return new WaitForSeconds(sec);

            

        }
    }