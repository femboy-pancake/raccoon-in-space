using UnityEngine;

public class floorbreak : MonoBehaviour
{
    public bool buttonactive2 = false;
    public bool buttonactive1 = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject.FindGameObjectsWithTag("button");
    }

    // Update is called once per frame
    void Update()
    {


        buttonactive1 = GameManager.main.button1;

        buttonactive2 = GameManager.main.button2;


        if (buttonactive1 == true && buttonactive2 == true)
        {
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
    }

}

    

    

