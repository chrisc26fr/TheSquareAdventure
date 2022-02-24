using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCustom : MonoBehaviour
{
    public GameObject Player;
    public void Start()
    {
        print(PlayerPrefs.GetInt("color"));
        if (PlayerPrefs.GetInt("color") == 1)
        {
            Player.GetComponent<Renderer>().material.color = new Color(0, 255, 247);
        }
        else if (PlayerPrefs.GetInt("color") == 2)
        {
            Player.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (PlayerPrefs.GetInt("color") == 3)
        {
            Player.GetComponent<Renderer>().material.color = Color.yellow;
        }
    }
    


}
