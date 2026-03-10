using UnityEngine;

public class GravityRacocoonScript : MonoBehaviour
{
    public float playerSpeed = 8.0f;
    PlayerScript playerscript;
    public Transform playerSprite;
    public playerJumpScript playerjumpscript;
    private PolygonCollider2D polygoncollider2D;
    public BoxCollider2D boxcollider2D;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerscript = GetComponent<PlayerScript>();
        playerjumpscript = GetComponent<playerJumpScript>();
        polygoncollider2D = GetComponent<PolygonCollider2D>();
    }

    // Update is called once per frame
    void Update()
        //MAKE GRAVTIY CHANGE DIRECTION
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Physics2D.gravity = new Vector2(-9.8f, 0);
            //transform.Rotate(0, 0, -90);
            playerSprite.rotation = Quaternion.Euler(0, 0, -90);
            playerscript.isVertical = true;
            playerjumpscript.jumpableSurface = Vector2.left;
            //playerSprite.rotation = Quaternion.Euler(0, 0, -90);
        }
        

            if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Physics2D.gravity = new Vector2(9.8f, 0);
            playerscript.isVertical = true;
            //playerSprite.rotation = Quaternion.Euler(0, 0, 90 );
            playerSprite.rotation = Quaternion.Euler(0, 0, 90);
            playerjumpscript.jumpableSurface = Vector2.right;
        }
        

            if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Physics2D.gravity = new Vector2(0, 9.8f);
            playerscript.isVertical = false;
            //playerSprite.transform.localScale(1, 1, -1);
            //transform.Rotate(0, 0, 180);
            playerSprite.rotation = Quaternion.Euler(0, 0, 180);
            
            playerjumpscript.jumpableSurface = Vector2.up;
        }
        

            if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Physics2D.gravity = new Vector2(0, -9.8f);
            playerscript.isVertical = false;
            playerSprite.rotation = Quaternion.Euler(0, 0, 0);

            playerjumpscript.jumpableSurface = Vector2.down;
        }
        
    }


    
}
