using UnityEngine;

public class spritechanger : MonoBehaviour
{
    [SerializeField] Sprite[] BombSprite;
    private Sprite  explodingSprite;

    private void OnTriggerEnter2D(Collider2D Other)
    {

    if (Other.tag == "Glass")
      
        
        
        {
            explodingSprite = BombSprite[1];
            gameObject.GetComponent<SpriteRenderer>().sprite = explodingSprite;
        }
            
    
    

    }
}
