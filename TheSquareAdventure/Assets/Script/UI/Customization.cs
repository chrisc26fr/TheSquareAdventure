using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customization : MonoBehaviour
{
    public void Start()
    {
        if(PlayerPrefs.HasKey("color"))
        {}
        else
        {
            PlayerPrefs.SetInt("color", 1);
        }
    }
    public void ColorAqua()
    {
        PlayerPrefs.SetInt("color", 1);
    }
    public void ColorRed()
    {
        PlayerPrefs.SetInt("color", 2);
    }
    public void ColorYellow()
    {
        PlayerPrefs.SetInt("color", 3);
    }
}
