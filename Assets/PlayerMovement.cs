using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D ballBod;
    public float speed = 10f;
    private float horizontalInput;
    private float jump;
    public bool onGround = true;

    public GameObject moveBox;
    private bool isMovingBox = false;
    // Start is called before the first frame update
    void Start()
    {
        jump = Input.GetAxis("Vertical");
        ballBod = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        //jump = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");


        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //transform.Translate(Vector3.up * jump * Time.deltaTime * speed);
        if (Input.GetKeyDown(KeyCode.W) && onGround == true)
        {
            onGround = false;
            ballBod.AddForce(transform.up * 400);
            if (isMovingBox == true)
            {
                moveBox.GetComponent<MoveTheBox>().isColliding = false;
                isMovingBox = false;
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

    }
        private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "floor" || collision.gameObject.tag == "moveMe")
        {
            onGround = true;
        }
        if (collision.gameObject.tag == "moveMe")
        {
            moveBox = GameObject.Find("moveBox1");
            moveBox.GetComponent<MoveTheBox>().isColliding = true;
            isMovingBox = true;
        }
    }

}
   

