using UnityEngine;
using UnityEngine.SceneManagement;

public class lvl4Teleport : MonoBehaviour
{
    public GameObject spawn;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //other.transform.parent.transform.position = new Vector3(0, 0, 0);
            spawn.transform.position = new Vector3(-0.7f, 5.21f, -1.2f);

            Physics2D.gravity = new Vector2(0, -9.8f);
            SceneManager.LoadScene("level 5");
            other.transform.parent.position = new Vector3(-0.7f, 5.21f, -1.2f); 


        }
    }
}
