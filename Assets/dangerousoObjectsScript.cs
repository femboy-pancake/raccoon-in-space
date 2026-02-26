using UnityEngine;

public class dangerousObjectsScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    //if player gets hit, teleports to beginning of level
    private void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.tag == "Player")
        {

             Other.transform.position = new Vector3(-13.15f, -4.41f, 0);
        }
    }
    
}
