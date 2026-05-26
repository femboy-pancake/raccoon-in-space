using UnityEngine;
using System.Collections;

public class lvl5deadly : MonoBehaviour
{
    public GameObject[] Cloud1;
    public GameObject[] Cloud2;
    public GameObject Cloud3;
    //public playerJumpScript playerjumpscript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      

    }

    private void Awake()
    {
        Cloud1 = GameObject.FindGameObjectsWithTag("Cloud1");
        Cloud2 = GameObject.FindGameObjectsWithTag("Cloud2");
        Cloud3 = GameObject.FindGameObjectWithTag("Cloud3");
    }
    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.tag == "Player")
        {
            Cloud1[0].GetComponent<BoxCollider2D>().enabled = false;
            Cloud1[1].GetComponent<BoxCollider2D>().enabled = false;
            Cloud2[0].GetComponent<BoxCollider2D>().enabled = false;
            Cloud2[1].GetComponent<BoxCollider2D>().enabled = false;
            Cloud3.GetComponent<BoxCollider2D>().enabled = false;


            Cloud1[0].GetComponent<SpriteRenderer>().enabled = false;
            Cloud1[1].GetComponent<SpriteRenderer>().enabled = false;
            Cloud2[0].GetComponent<SpriteRenderer>().enabled = false;
            Cloud2[1].GetComponent<SpriteRenderer>().enabled = false;
            Cloud3.GetComponent<SpriteRenderer>().enabled = false;
            //start cloud Coroutine
            Cloud1[0].GetComponent<cloudspawn>().Restart();
            Cloud1[1].GetComponent<cloudspawn>().Restart();
            Cloud2[0].GetComponent<cloudspawn2>().Restart();
            Cloud2[1].GetComponent<cloudspawn2>().Restart();
            Cloud3.GetComponent<cloudspawn3>().Restart();
            GameManager.main.RestartLevel();

        }
    }

    
}
