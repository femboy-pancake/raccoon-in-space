using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lvl5teleporter : MonoBehaviour
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
            SceneManager.LoadScene("level 6");
            other.transform.parent.position = new Vector3(-12.41f, 5.81f, 8.928f);


        }
    }
}

