using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject mobilToFollow;
    //posisi ini harus sama dengan posisi kamera
    void LateUpdate()
    {
       transform.position = mobilToFollow.transform.position + new Vector3(0,0,-10);
    }
}
