using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartMainMenuScript : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("Level");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
