using UnityEngine;

public class boss : MonoBehaviour
{
    public int maxHealth = 3;
    int currentHealth;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;
    }

    

    public void TakeDamage(int Damage)
    {

        

        currentHealth = currentHealth - Damage;
        if (currentHealth <= 0)
        {
            Destroy(gameObject);

        }
    }

    

}
