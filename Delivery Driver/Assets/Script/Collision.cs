using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("DIO GANTENG");
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("APAAN TUHH?");
    }
}
