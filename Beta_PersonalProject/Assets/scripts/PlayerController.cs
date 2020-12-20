using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private float speed = 10.0f;
    private float turnSpeed = 10.0f;
    private float horizontalinput;
    private float forwardInput;
    public AudioClip Crash;
    public AudioClip lose;
    private AudioSource playerAudio;
    private GameManager gameManager;


    // Start is called before the first frame update
    void Start()
    {

        playerAudio = GetComponent<AudioSource>();
       gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

        // dont go off screen
        if (transform.position.x < -60)
        {
            transform.position = new Vector3(-60, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 60)
        {
            transform.position = new Vector3(60, transform.position.y, transform.position.z);
        }
        //turn on input
        horizontalinput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //move forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalinput);

    }
    //hitting everything
    private void OnCollisionEnter(Collision collision)
    {
        //if you hit the farmer
        if (collision.gameObject.CompareTag("Finish"))
        {
            playerAudio.PlayOneShot(Crash, 1.0f);
            SceneManager.LoadScene("Level2");

        }
        //if you hit an enemy
        if (collision.gameObject.CompareTag("enemy"))
        {
            gameManager.GameOver();
            Debug.Log("You lost :(");
            playerAudio.PlayOneShot(lose, 1.0f);
            Time.timeScale = 0;
        }
        //level 3 load
        if (collision.gameObject.CompareTag("L3"))
        {
            playerAudio.PlayOneShot(Crash, 1.0f);
            SceneManager.LoadScene("Level3");
        }

        if (collision.gameObject.CompareTag("WIN"))
        {
            playerAudio.PlayOneShot(Crash, 1.0f);
            SceneManager.LoadScene("Finish");
        }
    }

}


