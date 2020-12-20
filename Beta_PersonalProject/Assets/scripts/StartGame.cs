using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour
{
    public string URL = "https://github.com/NM6293/BetaGameVersion";
    public void GoToSene1()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void GoToURL()
    {
        Application.OpenURL(URL);
    }
}