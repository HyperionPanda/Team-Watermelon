using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D ballBod;
    public float speed = 10f;
    private float horizontalInput;
    private float jump;
    public bool onGround = true;
    public TextMeshProUGUI dialogue;

    public int level = 0;

    public bool hiding = false;

    private bool TalktheTalk = false;
    

    public GameObject moveBox;
    private bool isMovingBox = false;
    public GameObject levelCONTROLLER;
    // Start is called before the first frame update

    public string LastKeyPress = "";

    private AudioClip aud;


    void Start()
    {
        aud = GetComponent<AudioSource>().clip;
        GameObject.Find("LevelController").GetComponent<BeginControl>().level = level;
        jump = Input.GetAxis("Vertical");
        ballBod = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (TalktheTalk != true)
        {


            //issue here?
            //hiding = false;

            //jump = Input.GetAxis("Vertical");
            horizontalInput = Input.GetAxis("Horizontal");

            if (Input.GetKeyDown(KeyCode.A))
            {
                LastKeyPress = "A";
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                LastKeyPress = "D";
            }
            transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
            //transform.Translate(Vector3.up * jump * Time.deltaTime * speed);
            if (Input.GetKeyDown(KeyCode.Space) && onGround == true)
            {
                onGround = false;
                //change value nect to Vector2 for change in jump height
                AudioSource.PlayClipAtPoint(aud, transform.position);
                ballBod.AddForce(Vector2.up * 8, ForceMode2D.Impulse);

                //moveBox = null;
                //transform.Translate(Vector3.up * jump * Time.deltaTime * speed);

                if (isMovingBox == true)
                {
                    moveBox.GetComponent<MoveTheBox>().isColliding = false;
                    isMovingBox = false;
                    moveBox = null;
                }

            }
        }
        /*
        if (Input.GetKeyDown(KeyCode.Mouse1) && onGround == true)
        {
            
        }
        */

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "WinZone")
        {
            if (level == 5)
            {
                SceneManager.LoadScene("YouWin");
            }
            else {
                levelCONTROLLER = GameObject.Find("LevelController");
                level = level + 1;
                levelCONTROLLER.GetComponent<BeginControl>().level = level;
                DontDestroyOnLoad(levelCONTROLLER);
                SceneManager.LoadScene(level);
            }

        }
        else if (other.gameObject.tag == "Dialogue")
        {
            //TalktheTalk = true;
            //dialogue.text = "Oh, you're lost arn't you? On an adventure eh? Well, do be careful. Continue onward to find your way now hohoho";
            
            //StartCoroutine(DialogueHold());
            
        }
        if (other.gameObject.tag == "Hiding")
        {
            hiding = true;
        }
        if (other.gameObject.tag == "NotHiding")
        {
            hiding = false;
        }
        if (other.gameObject.tag == "Sight" && hiding == false)
        {
            SceneManager.LoadScene(level);
        }




    }
        private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "floor" || collision.gameObject.tag == "moveMe")
        {
            onGround = true;
        }
        if (collision.gameObject.tag == "floor" || collision.gameObject.tag == "moveMeRock")
        {
            onGround = true;
        }



        if (collision.gameObject.tag == "moveMe")
        {
            //moveBox = GameObject.Find("moveBox1");
            //moveBox.GetComponent<MoveTheBox>().isColliding = true;
            isMovingBox = true;
        }
        if (collision.gameObject.tag == "moveMeRock")
        {
            moveBox = GameObject.Find("moveCircle");
            moveBox.GetComponent<MoveTheBox>().isColliding = true;
            isMovingBox = true;
        }
    }
    IEnumerator DialogueHold()
    {
       
        yield return new WaitForSeconds(5);
        TalktheTalk = false;

    }

    /*private void OnTriggerEnterStay2D(Collider2D stay)
    {
        if (stay.gameObject.tag == "Hiding")
        {
            hiding = true;

        }
        




    }
    */
}
   

