using UnityEngine;

public class spritechanger : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] Sprite[] BombSprite;
    private Sprite explodingSprite;
    Animator bombExplotion;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bombExplotion = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D Other)
    {

        if (Other.tag == "Glass")



        {

            bombExplotion.SetTrigger("explode");


            rb.constraints = RigidbodyConstraints2D.FreezeAll;
        }




    }
}
