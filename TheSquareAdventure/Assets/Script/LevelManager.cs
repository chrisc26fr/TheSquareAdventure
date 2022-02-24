using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public GameObject Level1;
    public GameObject Level2;
    public GameObject Level3;
    public GameObject Level4;
    public GameObject Level5;
    public GameObject Level6;
    private void Awake()
    {
        if(LevelUI.levelLoad == 1)
        {
            Level1.SetActive(true);
        }
        else if(LevelUI.levelLoad == 2)
        {
            Level2.SetActive(true);
        }
        else if (LevelUI.levelLoad == 3)
        {
            Level3.SetActive(true);
        }
        else if (LevelUI.levelLoad == 4)
        {
            Level4.SetActive(true);
        }
        else if (LevelUI.levelLoad == 5)
        {
            Level5.SetActive(true);
        }
        else if (LevelUI.levelLoad == 6)
        {
            Level6.SetActive(true);
        }
    }
    
   
}
