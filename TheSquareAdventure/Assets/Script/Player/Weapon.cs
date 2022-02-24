using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public AudioSource SoundC;
   
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && PlayerMovement.canShoot)
        {
            Shoot();
            SoundC.Play();
        }
    }
    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
