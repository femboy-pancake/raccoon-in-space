using UnityEngine;
using Unity.VisualScripting;

public class playerJumpScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidBody;
    [SerializeField] private float jumpForce = 6;
    public Vector2 jumpableSurface;

   
    // Update is called once per frame
    void Update()
    {

        Debug.DrawRay(transform.position, jumpableSurface * 0.8f, Color.red);

        if (Input.GetKeyDown(KeyCode.Space) && GetIsFloor())
        {
            jump();

        }
    }

    private bool GetIsFloor()
    {
        return Physics2D.Raycast(transform.position, jumpableSurface, 1f, LayerMask.GetMask("jumpable surfance"));

    }

    private void jump()
    {
        rigidBody.AddForce(-jumpableSurface * jumpForce, ForceMode2D.Impulse);
    }

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        jumpableSurface = Vector2.down;
    }
}
