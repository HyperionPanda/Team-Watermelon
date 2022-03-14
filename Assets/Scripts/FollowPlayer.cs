using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    private GameObject emp;
    private GameObject view;
    private GameObject inside;
    private GameObject inside1;
    private GameObject inside2;
    private GameObject inside3;
    private GameObject inside4;
    private GameObject checkLevel;
    private int currentlevel;
    private GameObject current;
    // Start is called before the first frame update
    void Start()
    {
        current = this.gameObject;
        checkLevel = GameObject.Find("LevelController");
       
        if (checkLevel.GetComponent<BeginControl>().level == 5)
        {
            view = GameObject.Find("View Border");
            emp = GameObject.Find("security guard");
            inside = GameObject.Find("Inside border");
            inside1 = GameObject.Find("Inside border (1)");
            inside2 = GameObject.Find("Inside border (2)");
            inside3 = GameObject.Find("Inside border (3)");
            inside4 = GameObject.Find("Inside border (4)");
        }
    }

    // Update is called once per frame

    void Update()
    {
        if (checkLevel.GetComponent<BeginControl>().level == 5 && (current == emp || current == view || current == inside || current == inside1 || current == inside2 || current == inside3 || current == inside4))
        {
            if (emp.GetComponent<MoveUrAss>().direction == "left")
            {
                transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, offset.z);
            }
            else if (emp.GetComponent<MoveUrAss>().direction == "right")
            {
                transform.position = new Vector3(player.position.x - offset.x, player.position.y + offset.y, offset.z);


            }
        }
        else 
        {
            transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, offset.z);
        }
    }
}
