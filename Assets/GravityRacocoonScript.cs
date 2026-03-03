using UnityEngine;

public class GravityRacocoonScript : MonoBehaviour
{
    public float playerSpeed = 8.0f;
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
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.up * playerSpeed * Time.deltaTime);
            }
            
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.down * playerSpeed * Time.deltaTime);
            }
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Physics2D.gravity = new Vector2(9.8f, 0);
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.up * playerSpeed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.down * playerSpeed * Time.deltaTime);
            }
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Physics2D.gravity = new Vector2(0, 9.8f);
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.left * playerSpeed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.right * playerSpeed * Time.deltaTime);
            }
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Physics2D.gravity = new Vector2(0, -9.8f);

            
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.left * playerSpeed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.right * playerSpeed * Time.deltaTime);
            }
        }
    }


    
}
