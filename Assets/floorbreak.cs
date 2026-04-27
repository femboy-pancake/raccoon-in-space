using UnityEngine;

public class floorbreak : MonoBehaviour
{
    public bool buttonactive2 = false;
    public bool buttonactive1 = false;
    public GameObject[] buttons;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject.FindGameObjectsWithTag("button");
    }

    // Update is called once per frame
    void Update()
    {
      
        //Kolla om button 1 är sann
        //om sann sätt "buttonactive1 = true"
       
        //Kolla om button 2 är sann
        //om sann sätt "buttonactive2 = true"
        if (buttonactive1 == true && buttonactive2 == true)
        {
            Destroy(gameObject);
        }

    }

    
}
