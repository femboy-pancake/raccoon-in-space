using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

public class LightbulbScript : MonoBehaviour
{
    public Light2D light;

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
            Light();
            //enable the entire room's sprites
            //change a few sprites from 1 color to other
            //keep background, raccoon and lightbulb the same
        }


    }

    void Light()
    {
        light.intensity = 1;
    }
}
