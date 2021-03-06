using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController : MonoBehaviour
{
    private float privateEnergy = 100;
    private float CurrentprivateEnergy = 0;
    public int Energy = 100;
    //public int level = 0;

    
    private int Score = 0;
    public TextMeshProUGUI energyText;

    public GameObject player;
    //public GameObject moveBox;

    private Vector3 playerPosition;
    public GameObject levelcontrol;

    //GameObject[] moveBoxes;
    // Start is called before the first frame update
    void Start()
    {

        energyText.text = "Energy: " + Energy;
        playerPosition = player.transform.localPosition;
        CurrentprivateEnergy = privateEnergy;
        levelcontrol = GameObject.Find("LevelController");
    }

    // Update is called once per frame
    void Update()
    {
        if (Energy < 0)
        {
            levelcontrol.GetComponent<BeginControl>().end = 9;
            DontDestroyOnLoad(levelcontrol);
            
            SceneManager.LoadScene("YouLose");
        }
        //added time.deltatime here
        energyText.text = "Energy: " + (Energy);
        if(CurrentprivateEnergy == (privateEnergy+100))
        {
            CurrentprivateEnergy = privateEnergy;
            Energy = Energy - 1;
        }
        if (player.transform.localPosition != playerPosition)
        {
            //Time.deltaTime
            playerPosition = player.transform.localPosition;
            privateEnergy = privateEnergy - 1;
        }
    }
    
}
