using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPowerUpScript : MonoBehaviour
{
    public GameObject JumpPowerScreen;
    public AudioSource soundB;
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
            soundB.Play();
            JumpPowerScreen.SetActive(true);

        }



    }
}
