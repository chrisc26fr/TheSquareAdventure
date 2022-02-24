using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public AudioSource sound;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Inventaire.keyA = true;
            Destroy(gameObject);
            sound.Play();
        }



    }
}
