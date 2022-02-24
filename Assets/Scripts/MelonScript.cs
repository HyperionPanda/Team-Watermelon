using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MelonScript : MonoBehaviour
{
    public GameController master;
    private AudioClip aud;
    // Start is called before the first frame update
    void Start()
    {
        aud = GetComponent<AudioSource>().clip;
    }

    // Update is called once per frame
    void Update()
    {


    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && this.gameObject.tag == "Melon")
        {
            AudioSource.PlayClipAtPoint(aud,transform.position);
            master.GetComponent<GameController>().Energy = master.GetComponent<GameController>().Energy + 10;
            Destroy(gameObject);
        }
        else if (this.gameObject.tag == "trap" && other.gameObject.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(aud, transform.position);
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
    /*
    IEnumerator letitPlay()
    {
        yield return new WaitForSeconds(.2);
        Destroy(gameObject);
    }
    */
}
