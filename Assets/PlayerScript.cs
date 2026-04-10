using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public PlayerScript PriorToLevel3;
    public GravityRacocoonScript GravityScript;
    public float playerSpeed = 1.0f;
    public bool isVerticalleft = false;
    public bool isVerticalright = false;
    public bool isUpsidedown = false;
    public GameObject Graphics;
    static GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (player == null)
        {
            player = this.gameObject;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    // makes so the player can walk left and right
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            if (isVerticalleft == false)
            {
                transform.Translate(Vector3.left * playerSpeed * Time.deltaTime);
                Graphics.GetComponent<SpriteRenderer>().flipX = true;

            }

            if (isUpsidedown == true)
            {
                Graphics.GetComponent<SpriteRenderer>().flipX = false;
            }

        }
        if (Input.GetKey(KeyCode.D))
        {

            if (isVerticalleft == false)
            {
                transform.Translate(Vector3.right * playerSpeed * Time.deltaTime);
                Graphics.GetComponent<SpriteRenderer>().flipX = false;


                if (isUpsidedown == true)
                {
                    Graphics.GetComponent<SpriteRenderer>().flipX = true;
                }
            }


        }
        if (Input.GetKey(KeyCode.W))
        {

            if (isVerticalleft == true)
            {
                transform.Translate(Vector3.up * playerSpeed * Time.deltaTime);
                Graphics.GetComponent<SpriteRenderer>().flipX = true;
            }

            if (isVerticalright == true)
            {
                transform.Translate(Vector3.up * playerSpeed * Time.deltaTime);
                Graphics.GetComponent<SpriteRenderer>().flipX = false;
            }
        }
        if (Input.GetKey(KeyCode.S))
        {

            if (isVerticalleft == true)
            {
                transform.Translate(Vector3.down * playerSpeed * Time.deltaTime);
                Graphics.GetComponent<SpriteRenderer>().flipX = false;
            }

            if (isVerticalright == true)
            {
                transform.Translate(Vector3.down * playerSpeed * Time.deltaTime);
                Graphics.GetComponent<SpriteRenderer>().flipX = true;
            }

        }
    }
    //makes so player don't die when spawning in a new scene
    private void Awake()
    {
        


       
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "gravity gun")
        {
            GravityScript.enabled = true;
            //PriorToLevel3.enabled = false;
            Destroy(other.gameObject);
        }


    }
}
