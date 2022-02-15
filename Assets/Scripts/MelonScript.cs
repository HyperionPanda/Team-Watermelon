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
        if (other.gameObject.tag == "Player")
        {
            master.GetComponent<GameController>().Energy = master.GetComponent<GameController>().Energy + 10;
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "trap")
        {
            master.GetComponent<GameController>().Energy = master.GetComponent<GameController>().Energy - 25;
            Destroy(gameObject);
        }
    }
    /*
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.tag == "Melon")
        {
            master.GetComponent<GameController>().Energy = master.GetComponent<GameController>().Energy + 10;
            Destroy(gameObject);
        }
        if (collision.tag == "trap")
        {
            master.GetComponent<GameController>().Energy = master.GetComponent<GameController>().Energy - 25;
            Destroy(gameObject);
        }
    }
    */
}
