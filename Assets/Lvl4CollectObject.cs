using UnityEngine;

public class Lvl4CollectObject : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            GameObject teleporter;
            teleporter = GameObject.FindGameObjectWithTag("teleport");
            teleporter.GetComponent<lvl4Teleport>().enabled = true;
            teleporter.GetComponent<lvl4deadly>().enabled = false;
            gameObject.SetActive(false);

            GameObject[] DestroyableWall;
            DestroyableWall = GameObject.FindGameObjectsWithTag("DestroyableWall");

            foreach (GameObject wall in DestroyableWall)
            {
                wall.GetComponent<BoxCollider2D>().enabled = false;
                wall.GetComponent<SpriteRenderer>().enabled = false;
            }
        }



    }
}
