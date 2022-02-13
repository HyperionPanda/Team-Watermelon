using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController : MonoBehaviour
{
    private int privateEnergy = 1000;
    private int CurrentprivateEnergy = 0;
    public int Energy = 100;
    //public int level = 0;

    
    private int Score = 0;
    public TextMeshProUGUI energyText;

    public GameObject player;
    //public GameObject moveBox;

    private Vector3 playerPosition;

    //GameObject[] moveBoxes;
    // Start is called before the first frame update
    void Start()
    {

        energyText.text = "Energy: " + Energy;
        playerPosition = player.transform.localPosition;
        CurrentprivateEnergy = privateEnergy;
    }

    // Update is called once per frame
    void Update()
    {
        if (Energy < 0)
        {
            SceneManager.LoadScene("YouLose");
        }
        energyText.text = "Energy: " + Energy;
        if(CurrentprivateEnergy == (privateEnergy + 100))
        {
            CurrentprivateEnergy = privateEnergy;
            Energy = Energy - 1;
        }
        if (player.transform.localPosition != playerPosition)
        {
            playerPosition = player.transform.localPosition;
            privateEnergy = privateEnergy - 1;
        }
    }
    
}
