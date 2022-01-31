using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTheBox : MonoBehaviour
{
    public bool isColliding = false;
    public GameObject player;
    private float PlayerSpeed = 0;
    private int horizontalInput = 1;
    private float XScale = 0;
    private float YScale = 0;
    private float ZScale = 0;
    private bool Terraincollision = false;
    //private bool RightTerraincollision = false;

    // Start is called before the first frame update
    void Start()
    {
        XScale = gameObject.transform.localScale.x;
        YScale = gameObject.transform.localScale.y;
        ZScale = gameObject.transform.localScale.z;
        PlayerSpeed = player.GetComponent<PlayerMovement>().speed;
    }

    // Update is called once per frame
    void Update()
    {
        //Terraincollision = false;
        if (isColliding == true && player.transform.position.y <= gameObject.transform.position.y && player.transform.position.x < gameObject.transform.position.x &&Terraincollision == false)
        {
            //do -1 for if touched from other side

            gameObject.transform.position = new Vector3(player.transform.position.x + XScale, transform.position.y, transform.position.z);
            //transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * PlayerSpeed);
        }

        else if (isColliding == true && player.transform.position.y <= gameObject.transform.position.y && player.transform.position.x > gameObject.transform.position.x && Terraincollision == false)
        {
            //do -1 for if touched from other side
            gameObject.transform.position = new Vector3(player.transform.position.x - XScale, transform.position.y, transform.position.z);
            //transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * PlayerSpeed);
        }
        

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "terrain")
        {
            Terraincollision = true;
        }
    }
}
