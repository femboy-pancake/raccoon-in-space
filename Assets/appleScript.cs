using UnityEngine;

public class appleScript : MonoBehaviour
{

    Rigidbody2D rb;
    BoxCollider2D bc;
    public Vector3 originalPos;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bc = GetComponent<BoxCollider2D>();

        originalPos = gameObject.transform.position;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {


            rb.constraints = RigidbodyConstraints2D.None;
            GetComponent<Collider2D>().enabled = false;
            GetComponent<CircleCollider2D>().enabled = true;
        }
    }
}
