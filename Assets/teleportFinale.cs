using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teleportFinale : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {



            Physics2D.gravity = new Vector2(0, -9.8f);
            SceneManager.LoadScene("credits");
            other.transform.parent.position = new Vector3(-0.75f, 3.08f, 0.007062145f);


        }
    }
}

