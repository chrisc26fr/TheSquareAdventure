using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelUI : MonoBehaviour
{
    static public int levelLoad;
    public GameObject lvl2;
    public GameObject lvl3;
    public GameObject lvl4;
    public GameObject lvl5;
    public GameObject lvl6;
    private void Awake()
    {
        if(PlayerPrefs.GetInt("lvl")>=1)
        {
            lvl2.SetActive(true);
        }
        if(PlayerPrefs.GetInt("lvl")>= 2)
        {
            lvl3.SetActive(true);
        }
        if (PlayerPrefs.GetInt("lvl") >= 3)
        {
            lvl4.SetActive(true);
        }
        if (PlayerPrefs.GetInt("lvl") >= 4)
        {
            lvl5.SetActive(true);
        }
        if (PlayerPrefs.GetInt("lvl") >= 5)
        {
            lvl6.SetActive(true);
        }
    }

    public void level(int Level)
    {
        levelLoad = Level;
        SceneManager.LoadScene("Level");

    }


}
