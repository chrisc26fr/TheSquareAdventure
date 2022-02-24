using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSave : MonoBehaviour
{
    public int finDeNiveau;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (LevelUI.levelLoad == 1)
        {
            if (PlayerPrefs.HasKey("lvl"))
            { }
            else
            {
                PlayerPrefs.SetInt("lvl", 0);
            }
            if (PlayerPrefs.GetInt("lvl") == 0)
            {
                finDeNiveau = PlayerPrefs.GetInt("lvl");
                finDeNiveau = +1;
                PlayerPrefs.SetInt("lvl", finDeNiveau);
            }
            
        }
        if(LevelUI.levelLoad == 2)
        {
            if (PlayerPrefs.GetInt("lvl") == 1)
            {
                finDeNiveau = PlayerPrefs.GetInt("lvl");
                finDeNiveau += 1;
                PlayerPrefs.SetInt("lvl", finDeNiveau);
            }
            
        }
        if (LevelUI.levelLoad == 3)
        {
            if (PlayerPrefs.GetInt("lvl") == 2)
            {
                finDeNiveau = PlayerPrefs.GetInt("lvl");
                finDeNiveau += 1;
                PlayerPrefs.SetInt("lvl", finDeNiveau);
            }

        }
        if (LevelUI.levelLoad == 4)
        {
            if (PlayerPrefs.GetInt("lvl") == 3)
            {
                finDeNiveau = PlayerPrefs.GetInt("lvl");
                finDeNiveau += 1;
                PlayerPrefs.SetInt("lvl", finDeNiveau);
            }

        }
        if (LevelUI.levelLoad == 5)
        {
            if (PlayerPrefs.GetInt("lvl") == 4)
            {
                finDeNiveau = PlayerPrefs.GetInt("lvl");
                finDeNiveau += 1;
                PlayerPrefs.SetInt("lvl", finDeNiveau);
            }

        }
        if (LevelUI.levelLoad == 6)
        {
            if (PlayerPrefs.GetInt("lvl") == 5)
            {
                finDeNiveau = PlayerPrefs.GetInt("lvl");
                finDeNiveau += 1;
                PlayerPrefs.SetInt("lvl", finDeNiveau);
            }

        }
        SceneManager.LoadScene("Menu");
    }
}
