using UnityEngine;
using Unity.VisualScripting;

public class playerJumpScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidBody;
    [SerializeField] private float jumpForce = 6;



    // Update is called once per frame
    void Update()
    {

        Debug.DrawRay(transform.position, Vector2.down * 0.8f, Color.red);

        if (Input.GetKeyDown(KeyCode.Space) && GetIsFloor())
        {
            jump();

        }
    }

    private bool GetIsFloor()
    {
        return Physics2D.Raycast(transform.position, Vector2.down, 1f, LayerMask.GetMask("jumpable surfance"));

    }

    private void jump()
    {
        rigidBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
