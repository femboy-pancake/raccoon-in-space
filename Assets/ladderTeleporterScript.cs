using UnityEngine;
using UnityEngine.SceneManagement;

public class ladderTeleporterScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("level 3");

            other.transform.position = new Vector3(12.28474f, -4.4f, 0);
            // Thread.Sleep(TimeSpan.FromSeconds(0.5));
        }


    }
}
