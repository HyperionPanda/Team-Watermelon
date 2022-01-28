using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTheBox: MonoBehaviour
{
    public bool isColliding = false;
    public GameObject player;
    private float PlayerSpeed = 0;
    private int horizontalInput = 1;
    // Start is called before the first frame update
    void Start()
    {
        PlayerSpeed = player.GetComponent<PlayerMovement>().speed;
    }

    // Update is called once per frame
    void Update()
    {
        if(isColliding == true && player.transform.position.y <= gameObject.transform.position.y && player.transform.position.x < gameObject.transform.position.x)
        {
            //do -1 for if touched from other side
            gameObject.transform.position = new Vector3(player.transform.position.x + 1,transform.position.y,transform.position.x);
            //transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * PlayerSpeed);
        }

        else if(isColliding == true && player.transform.position.y <= gameObject.transform.position.y && player.transform.position.x > gameObject.transform.position.x)
            {
                //do -1 for if touched from other side
                gameObject.transform.position = new Vector3(player.transform.position.x -1, transform.position.y, transform.position.x);
                //transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * PlayerSpeed);
            }
        
    }
}
