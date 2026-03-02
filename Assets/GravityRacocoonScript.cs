using UnityEngine;

public class GravityRacocoonScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
        //MAKE GRAVTIY CHANGE DIRECTION
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Physics2D.gravity = new Vector2(-9.8f, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Physics2D.gravity = new Vector2(9.8f, 0);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Physics2D.gravity = new Vector2(0, 9.8f);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Physics2D.gravity = new Vector2(0, -9.8f);
        }
    }
}
