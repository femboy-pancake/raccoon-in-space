using UnityEngine;

public class playerdeathboss : MonoBehaviour
{
    public playerJumpScript playerjumpscript;
    
    void Start()
    {
        playerjumpscript = GameObject.Find("Player (2)").GetComponent<playerJumpScript>();

    }

  
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.tag == "Player")
        {
            
            GameManager.main.RestartLevel();

        }
    }
}
