using Unity.Collections;
using UnityEngine;

public class glass : MonoBehaviour
{
    
    public int maxHealth = 3;
    public int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;

    }



    public void TakeDamage(int Damage)
    {



        currentHealth = currentHealth - Damage;
        
    }

    private void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.tag == "bomb")
        {

            currentHealth = currentHealth - 1;
        
            Destroy(Other.gameObject,0.40f);
        }
    }

    private void Update()
    {


        if (currentHealth <= 0)
        {

            GameObject[] bossWall = GameObject.FindGameObjectsWithTag("BossWall");
            foreach (GameObject obj in bossWall)
            {
                obj.GetComponent<BoxCollider2D>().enabled = false;
                obj.GetComponent<SpriteRenderer>().enabled = false;
            }
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            gameObject.GetComponent<PolygonCollider2D>().enabled = false;
            gameObject.GetComponent<SpriteRenderer>().enabled = false;

        }
    }







}

