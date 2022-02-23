using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    private GameObject emp;
    private GameObject checkLevel;
    // Start is called before the first frame update
    void Start()
    {
        checkLevel = GameObject.Find("LevelController");
        if (checkLevel.GetComponent<BeginControl>().level == 5)
        {
            emp = GameObject.Find("security guard");
        }
    }

    // Update is called once per frame

    void Update()
    {
        if (checkLevel.GetComponent<BeginControl>().level == 5)
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
