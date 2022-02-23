using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUrAss : MonoBehaviour
{
    public GameObject employee;
    private float horizontalInput;
    private int speed = 1;
    public string direction = "left";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //75 or -4
        //horizontalInput = Input.GetAxis("Horizontal");
        if (direction == "left")
        {
            if (employee.transform.localPosition.x > -5)
            {
                transform.Translate(Vector3.left * Time.deltaTime * speed);
            }
            else
            {
                direction = "right";
            }
            
        }
        if (direction == "right")
        {
            if (employee.transform.localPosition.x < 74)
            {
                transform.Translate(Vector3.right * Time.deltaTime * speed);
            }
            else
            {
                direction = "left";
            }
        }
    }
}

