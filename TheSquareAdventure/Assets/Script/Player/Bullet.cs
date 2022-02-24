using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 20;
    public Rigidbody2D rb;
    public GameObject impactEffect;
    static public bool destroyAnim = false;
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        EnemyScript enemy = hitInfo.GetComponent<EnemyScript>();
        if(enemy != null)
        {
            enemy.TakeDammage(damage);
        }
        Instantiate(impactEffect, transform.position, transform.rotation);
        destroyAnim = true;
        Destroy(gameObject);
    }
}
