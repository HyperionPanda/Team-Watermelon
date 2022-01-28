using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController : MonoBehaviour
{
    private int privateEnergy = 10000;
    private int CurrentprivateEnergy = 0;
    public int Energy = 100;

    
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
        energyText.text = "Energy: " + Energy;
        if(CurrentprivateEnergy == (privateEnergy + 1000))
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
