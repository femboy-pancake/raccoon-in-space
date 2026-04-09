using UnityEngine;

public class button : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {


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
