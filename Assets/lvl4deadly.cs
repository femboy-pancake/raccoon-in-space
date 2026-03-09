using UnityEngine;

public class lvl4deadly : MonoBehaviour
{
    public playerJumpScript playerjumpscript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerjumpscript = GetComponent<playerJumpScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.tag == "Player")
        {

            Other.transform.position = new Vector3(-14.27f, -3.45f, 8.94f);
            Physics2D.gravity = new Vector2(0, -9.8f);
          
            Other.gameObject.transform.GetChild(0).transform.rotation = Quaternion.Euler(0, 0, 0);
            playerjumpscript.jumpableSurface = Vector2.down;
        }
    }
}
