using UnityEngine;

public class boss : MonoBehaviour
{
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }



    private void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.tag == "Player")
        {

            
            Destroy(gameObject);
        }

        GameObject[] BossFloor = GameObject.FindGameObjectsWithTag("Boss Floor");
        foreach (GameObject obj in BossFloor)
        {
            obj.GetComponent<BoxCollider2D>().enabled = false;
            obj.GetComponent<SpriteRenderer>().enabled = false;
        }
    }






}
