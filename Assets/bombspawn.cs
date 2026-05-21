using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
public class bombspawn : MonoBehaviour
{

    private float spawn;

    public GameObject bomb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawn = 10f;
        StartCoroutine(Wait(spawn));

    }

    // Update is called once per frame



    IEnumerator Wait(float sec)
    {
        //while Boss is alive, repeat attack between 5 and 10 seconds
        while (true)
        {
            yield return new WaitForSeconds(sec);

            spawn = 10f;

            Instantiate(bomb, transform.position, Quaternion.identity);

        }
    }
}
