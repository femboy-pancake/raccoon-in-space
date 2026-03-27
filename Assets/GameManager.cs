using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager main;
    public string LevelName;
    public Transform playerSprite;
    public playerJumpScript playerjumpscript;
    public Transform spawnPosition;
    public GameObject player;
    public PlayerScript playerscript;
    public Rigidbody2D ridgidbody;
    public GameObject collectobject;
    public GameObject[] DestroyableWall;

    private void Start()
    {
        main = this;
        //playerscript = GameObject.Find("player2").GetComponent<PlayerScript>();

    }
    public void RestartLevel()
    {
        player.transform.position = spawnPosition.position;
        player.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        Physics2D.gravity = new Vector2(0, -9.8f);
        playerSprite.rotation = Quaternion.Euler(0, 0, 0);
        playerjumpscript.jumpableSurface = Vector2.down;
        playerscript.isVerticalleft = false;
        playerscript.isVerticalright = false;
        playerscript.isUpsidedown = false;
        ridgidbody.linearVelocity = Vector3.zero;
        collectobject.SetActive(true);
        foreach (GameObject wall in DestroyableWall)
        {
            wall.GetComponent<BoxCollider2D>().enabled = true;
            wall.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
