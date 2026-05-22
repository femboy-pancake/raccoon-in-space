using UnityEngine;

public class walkingtutorial : MonoBehaviour
{
    public GameObject walkingTutorial;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == ("Player"))
        {
            walkingTutorial.SetActive(true);

        }

    }


    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == ("Player"))
        {
            walkingTutorial.SetActive(false);

        }
    }
}
