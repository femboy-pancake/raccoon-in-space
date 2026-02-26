using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float playerSpeed = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // makes so the player can walk left and right
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * playerSpeed * Time.deltaTime);
        }

        


    }
    //makes so player don't die when spawning in a new scene
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

        transform.position = new Vector3(-13.15f, -4.41f, 0);
    }
}
