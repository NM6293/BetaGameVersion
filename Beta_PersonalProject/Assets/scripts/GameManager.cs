using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI ResetText;
    public TextMeshProUGUI WONText;



    // Start is called before the first frame update
    void Start()
    {
    }

    //when you hit your enemy method
    public void GameOver()
    {
        Time.timeScale = 1;
        
        ResetText.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);


    }
    //winning method
    public void GameWon()
    {
        Time.timeScale = 0;
        
        WONText.gameObject.SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {
        //restart
        if (Input.GetKeyDown("r"))
        { //If you press R
            SceneManager.LoadScene("SampleScene"); //Load scene called Game
            Time.timeScale = 1;
        }
    }

}
