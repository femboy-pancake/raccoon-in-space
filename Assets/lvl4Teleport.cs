using UnityEngine;
using UnityEngine.SceneManagement;

public class lvl4Teleport : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {

            Physics2D.gravity = new Vector2(0, -9.8f);
            SceneManager.LoadScene("level 5");
            other.transform.position = new Vector3(-14.27f, -3.45f, 8.94f);


        }
    }
}
