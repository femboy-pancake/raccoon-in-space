using UnityEngine;

public class fireballLogic : MonoBehaviour
{
    public float fireballspeed = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * fireballspeed * Time.deltaTime);
    }
}
