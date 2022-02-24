using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{


    private void Update()
    {
        DoorOpen();
    }
    void DoorOpen()
  {
        if (Inventaire.keyA == true)
        {
            Destroy(gameObject);
        }
  }
}
