using UnityEngine;

public class button2 : MonoBehaviour
{
    public SpriteRenderer SpriteRenderer2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpriteRenderer2 = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.main.button2 == false)
        {
            SpriteRenderer2.color = Color.white;
        }
        else
        {
            SpriteRenderer2.color = Color.red;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            GameManager.main.button2 = true;
            

        }
    }
}
