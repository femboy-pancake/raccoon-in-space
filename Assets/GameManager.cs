using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager main;
    public string LevelName;

    public Transform spawnPosition;
    public GameObject player;

    private void Start()
    {
        main = this;
    }
    public void RestartLevel()
    {
        player.transform.position = spawnPosition.position;
        player.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
