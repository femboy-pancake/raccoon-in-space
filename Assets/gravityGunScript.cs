using UnityEngine;

public class gravityGunScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {

            Destroy(gameObject);
        }


    }
}
