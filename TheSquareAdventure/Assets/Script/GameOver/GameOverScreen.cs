using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "KillBlock"|| collision.transform.tag == "Enemy")
        {
            PlayerManager.isGameOver = true;
            gameObject.SetActive(false);
        }
    }
}
