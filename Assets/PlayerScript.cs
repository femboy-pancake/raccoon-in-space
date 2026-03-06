using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public PlayerScript PriorToLevel3;
    public GravityRacocoonScript GravityScript;
    public float playerSpeed = 1.0f;
    public bool isVertical = false;
    public GameObject Graphics;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // makes so the player can walk left and right
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            if (isVertical == false)
            {
                transform.Translate(Vector3.left * playerSpeed * Time.deltaTime);
                Graphics.GetComponent<SpriteRenderer>().flipX = true;

            }

        }
        if (Input.GetKey(KeyCode.D))
        {

            if (isVertical == false)
            {
                transform.Translate(Vector3.right * playerSpeed * Time.deltaTime);
                Graphics.GetComponent<SpriteRenderer>().flipX = false;

            }


        }
        if (Input.GetKey(KeyCode.W))
        {

            if (isVertical == true)
            {
                transform.Translate(Vector3.up * playerSpeed * Time.deltaTime);
            }

        }
        if (Input.GetKey(KeyCode.S))
        {

            if (isVertical == true)
            {
                transform.Translate(Vector3.down * playerSpeed * Time.deltaTime);
            }

        }
    }
    //makes so player don't die when spawning in a new scene
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

       // transform.position = new Vector3(-13.15f, -4.41f, 0);
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
