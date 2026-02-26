using System;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teleporterScript : MonoBehaviour
{


    //makes teleporting to also teleport the player
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("level 2");
            
            other.transform.position = new Vector3(-13.15f, -4.41f, 0);
           // Thread.Sleep(TimeSpan.FromSeconds(0.5));
        }


    }
}
