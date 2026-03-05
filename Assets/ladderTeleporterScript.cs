using UnityEngine;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

public class ladderTeleporterScript : MonoBehaviour
{

    public Light2D EnableLight;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            EnableLight = other.GetComponent<Light2D>();
            SceneManager.LoadScene("lighttest");
            EnableLight.enabled = true;

            other.transform.position = new Vector3(12.34f, -4.42f, 9);


            // Thread.Sleep(TimeSpan.FromSeconds(0.5));
        }


    }
}
