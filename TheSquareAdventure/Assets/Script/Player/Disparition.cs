using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparition : MonoBehaviour
{
    private void Start()
    {
        if (Bullet.destroyAnim) 
        {
            Destroy(gameObject, 0.05f);
            Bullet.destroyAnim = false;
        }
        
    }


}
