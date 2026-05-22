using UnityEngine;

public class spinnerspawn : MonoBehaviour
{
    public bool buttonactive2 = false;
    public bool buttonactive1 = false;

    void Start()
    {
        GameObject.FindGameObjectsWithTag("button");
    }

   
    void Update()
    {
        buttonactive1 = GameManager.main.button1;

        buttonactive2 = GameManager.main.button2;


        if (buttonactive1 == true && buttonactive2 == true)
        {
            gameObject.GetComponent<PolygonCollider2D>().enabled = true;
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}

