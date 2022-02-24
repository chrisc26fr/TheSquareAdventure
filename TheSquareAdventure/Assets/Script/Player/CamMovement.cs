using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float speedCam;
    void Start()
    {
        
    }


    void LateUpdate()
    {
        Vector3 desiredPos = player.position + offset;
        transform.position = Vector3.Lerp(transform.position, desiredPos, speedCam * Time.deltaTime);
    }
}
