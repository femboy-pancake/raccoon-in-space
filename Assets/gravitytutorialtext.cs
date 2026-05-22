using TMPro;
using UnityEngine;

public class gravitytutorialtext : MonoBehaviour
{

    public string dialogueText;

    public TMP_Text gravitytutorial;
    public GameObject dialogueBox;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            dialogueTrigger();
        }
    }

    public void dialogueTrigger()
    {

    }
}
