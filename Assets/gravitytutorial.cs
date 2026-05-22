using UnityEngine;

public class gravitytutorial : MonoBehaviour
{

    public GameObject gravityTutorial;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == ("Player"))
        {
            gravityTutorial.SetActive(true);

        }

    }


    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == ("Player"))
        {
            gravityTutorial.SetActive(false);

        }
    }
}
