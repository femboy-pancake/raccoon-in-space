using UnityEngine;

public class button1 : MonoBehaviour
{
   public SpriteRenderer SpriteRenderer1;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpriteRenderer1 = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.main.button1 == false)
        {
            SpriteRenderer1.color = Color.white;
        }
        else
        {
            SpriteRenderer1.color = Color.red;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {

            GameManager.main.button1 = true;
            
        }
    }

}
