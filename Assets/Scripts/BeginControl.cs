using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginControl : MonoBehaviour
{
    public int end = 8;
    public int level = 0;
    public GameObject levelcontrol;
    
    // Start is called before the first frame update
    void Start()
    {

        levelcontrol = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (end == 9)
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                end = end - 1;
                DontDestroyOnLoad(this.gameObject);
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
