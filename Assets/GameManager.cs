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
    public GameObject graphics;
    public PlayerScript playerscript;
    public Rigidbody2D ridgidbody;
    public GameObject collectobject;
    public GameObject[] DestroyableWall;
    public SpriteRenderer PlayerRenderer;

    private void Start()
    {
        if(main == null)
        {
            main = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        player = GameObject.Find("Player (2)");
        graphics = GameObject.Find("graphics");

        spawnPosition = GameObject.Find("SpawnPosition").transform;
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

    private void Awake()
    {
        // public Transform playerSprite;
        /*player = GameObject.Find("Player (2)");
        graphics = GameObject.Find("graphics");
        playerjumpscript = player.GetComponent<playerJumpScript>();
        playerscript = player.GetComponent<PlayerScript>();
        ridgidbody = player.GetComponent<Rigidbody2D>();
        PlayerRenderer = graphics.GetComponent<SpriteRenderer>();*/

    }
}
