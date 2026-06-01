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
    public GameObject[] MoreClouds;
    public bool button1;
    public bool button2;
    public GameObject[] floor;
    public GameObject[] roof;
    public GameObject bomb;
    public GameObject GlassWall;
    public GameObject[] bosswall;
    public GameObject fireball1;
    public GameObject fireball2;
    public GameObject thunderbolt;
    public GameObject SpinnerSpawn;
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

        


    }
    public void RestartLevel()
    {
        DestroyableWall = GameObject.FindGameObjectsWithTag("DestroyableWall");
        player.transform.position = spawnPosition.position;
        graphics.transform.position = spawnPosition.position;
        player.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        Physics2D.gravity = new Vector2(0, -9.8f);
        playerSprite.rotation = Quaternion.Euler(0, 0, 0);
        playerjumpscript.jumpableSurface = Vector2.down;
        playerscript.isVerticalleft = false;
        playerscript.isVerticalright = false;
        playerscript.isUpsidedown = false;
        ridgidbody.linearVelocity = Vector3.zero;
        MoreClouds = GameObject.FindGameObjectsWithTag("spawncloud");

        
        if (SpinnerSpawn != null)
        {
            SpinnerSpawn.GetComponent<PolygonCollider2D>().enabled = false;
            SpinnerSpawn.GetComponent<SpriteRenderer>().enabled = false;
        }
        

        



        Destroy(fireball1);
        Destroy(fireball2);
        Destroy(thunderbolt);
        Destroy(bomb);
        GlassWall = GameObject.Find ("glass wall red_0");
        

        if (GlassWall != null)
        {
            GlassWall.GetComponent<glass>().currentHealth = 3;
            GlassWall.GetComponent<BoxCollider2D>().enabled = true;
            GlassWall.GetComponent<PolygonCollider2D>().enabled = true;
            GlassWall.GetComponent<SpriteRenderer>().enabled = true;
        }

        


        if (bosswall != null)
        {
            foreach (GameObject bosswall in bosswall)
            {
                bosswall.GetComponent<BoxCollider2D>().enabled = true;
                bosswall.GetComponent<SpriteRenderer>().enabled = true;

            }
        }


       




        if (collectobject != null)
            collectobject.SetActive(true);

        if (DestroyableWall != null)
        {
            foreach (GameObject wall in DestroyableWall)
            {
                wall.GetComponent<BoxCollider2D>().enabled = true;
                wall.GetComponent<SpriteRenderer>().enabled = true;
            }
        }







        if (MoreClouds != null)
        {
            foreach (GameObject deadlyclouds in MoreClouds)
            {
                deadlyclouds.GetComponent<BoxCollider2D>().enabled = false;
                deadlyclouds.GetComponent<SpriteRenderer>().enabled = false;
                deadlyclouds.GetComponent<lvl4deadly>().enabled = false;
            }
        }

        button1 = false;

        button2 = false;

        foreach (GameObject floor in DestroyableWall)
        {
            floor.GetComponent<BoxCollider2D>().enabled = true;
            floor.GetComponent<SpriteRenderer>().enabled = true;
        }



        foreach (GameObject roof in roof)
        {
            roof.GetComponent<BoxCollider2D>().enabled = true;
            roof.GetComponent<SpriteRenderer>().enabled = true;
        }

    }

    private void Awake()
    {

        player = GameObject.Find("Player (2)");
        graphics = GameObject.Find("graphics");
        playerSprite = graphics.GetComponent<Transform>();
        spawnPosition = GameObject.Find("SpawnPosition").transform;
        playerjumpscript = player.GetComponent<playerJumpScript>();
        playerscript = player.GetComponent<PlayerScript>();
        ridgidbody = player.GetComponent<Rigidbody2D>();
        PlayerRenderer = player.GetComponent<SpriteRenderer>();
        DestroyableWall = GameObject.FindGameObjectsWithTag("DestroyableWall");
        collectobject = GameObject.Find("key");
        roof = GameObject.FindGameObjectsWithTag("roof");
        
        GlassWall = GameObject.Find("glass");
        bosswall = GameObject.FindGameObjectsWithTag("BossWall");
        fireball1 = GameObject.Find("fireball for boss_0 1(Clone)");
        fireball2 = GameObject.Find("fireball2(Clone)");
        thunderbolt = GameObject.Find("boss thundercloud warning_0(Clone)");
        SpinnerSpawn = GameObject.Find("spinnerspawn");





    }

    void Update()
    {
        //RESTARTKNAPP
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartLevel();
        }

        if (spawnPosition == null)
        {
            spawnPosition = GameObject.Find("SpawnPosition").transform;
        }

        if (collectobject == null)
        {
            collectobject = GameObject.Find("key");
        }

        if (roof == null)
        {
            roof = GameObject.FindGameObjectsWithTag("roof");
        }


        if (SpinnerSpawn == null)
        {
            SpinnerSpawn = GameObject.Find("spinnerspawn");
        }


        if (fireball1 == null)
        {
            fireball1 = GameObject.Find("fireball for boss_0 1(Clone)");
        }

        if (fireball2 == null)
        {
            fireball2 = GameObject.Find("fireball2(Clone)");
        }

        if (thunderbolt == null)
        {
            thunderbolt = GameObject.Find("boss thundercloud warning_0(Clone)");
        }



        if (bomb == null)
        {
            bomb = GameObject.Find("bomb for boss_0 1(Clone)");
        }

        if (bosswall == null)
        {
            bosswall = GameObject.FindGameObjectsWithTag("BossWall");
        }

    }


}
