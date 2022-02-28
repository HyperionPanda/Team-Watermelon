using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUrAss : MonoBehaviour
{
    public GameObject employee;
    private float horizontalInput;
    private int speed = 2;
    public string direction = "left";
    private bool start = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(start == true)
        {
            if (employee.transform.localPosition.x > -5)
            {
                //while she is moving right and looking right so long as this is right she will look and move left
                transform.Translate(Vector3.left * Time.deltaTime * speed);
            }
            else
            {
                start = false;
                direction = "right";
                employee.transform.Rotate(0, -180, 0);
            }
        }
        //75 or -4
        //horizontalInput = Input.GetAxis("Horizontal");
      
        if (direction == "left" && start == false)
        {
            if (employee.transform.localPosition.x > -5)
            {
                //while she is moving right and looking right so long as this is right she will look and move left
                transform.Translate(Vector3.left * Time.deltaTime * speed);
            }
            else
            {
                direction = "right";
                employee.transform.Rotate(0, -180, 0);
            }
            
        }
        if (direction == "right"&&start == false)
        {
            if (employee.transform.localPosition.x < 74)
            {
                //when moving and looking left, so long as this is left she will look right and move right
                transform.Translate(Vector3.left * Time.deltaTime * speed);
            }
            else
            {
                direction = "left";
                employee.transform.Rotate(0, 180, 0);
            }
        }
    }
}

