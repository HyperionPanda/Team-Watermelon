using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MelonScript : MonoBehaviour
{
    public GameController master;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Play")
        {
            master.GetComponent<GameController>().Energy = master.GetComponent<GameController>().Energy + 10;
            Destroy(gameObject);
        }
    }
}