using UnityEngine;

public class GravityRacocoonScript : MonoBehaviour
{
    public float playerSpeed = 8.0f;
    PlayerScript playerscript;
    public Transform playerSprite;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerscript = GetComponent<PlayerScript>();
    }

    // Update is called once per frame
    void Update()
        //MAKE GRAVTIY CHANGE DIRECTION
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Physics2D.gravity = new Vector2(-9.8f, 0);

            playerscript.isVertical = true;
            playerSprite.rotation = Quaternion.Euler(0, 0, -90);
        }
        

            if (Input.GetKey(KeyCode.RightArrow))
        {
            Physics2D.gravity = new Vector2(9.8f, 0);
            playerscript.isVertical = true;
            playerSprite.rotation = Quaternion.Euler(0, 0, 90 );
        }
        

            if (Input.GetKey(KeyCode.UpArrow))
        {
            Physics2D.gravity = new Vector2(0, 9.8f);
            playerscript.isVertical = false;
            playerSprite.rotation = Quaternion.Euler(0, 0, 180);
        }
        

            if (Input.GetKey(KeyCode.DownArrow))
        {
            Physics2D.gravity = new Vector2(0, -9.8f);
            playerscript.isVertical = false;
            playerSprite.rotation = Quaternion.Euler(0, 0, 90);
        }
        
    }


    
}
