using UnityEngine;

public class Lvl4CollectObject : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            GameObject teleporter;
            teleporter = GameObject.FindGameObjectWithTag("teleport");
            teleporter.GetComponent<lvl4Teleport>();
            Destroy(gameObject);
        }


    }
}
