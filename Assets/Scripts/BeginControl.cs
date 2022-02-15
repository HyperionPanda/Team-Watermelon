using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginControl : MonoBehaviour
{
    public int end = 8;
    public int level = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (end == 9)
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                SceneManager.LoadScene(level);
            }
        }
        else if (end == 10)
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                level = 0;
                SceneManager.LoadScene("Level 1");
            }
        }
        
    }
}
