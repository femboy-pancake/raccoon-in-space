using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

public class BorderTeleporterScript : MonoBehaviour
{
    public Light2D EnableLight;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            EnableLight = other.GetComponent<Light2D>();
            Physics2D.gravity = new Vector2(0, -9.8f);
            SceneManager.LoadScene("level 4");
            EnableLight.enabled = false;
            other.transform.position = new Vector3(-14.27f, -3.45f, 8.94f);

        }
    }
}
