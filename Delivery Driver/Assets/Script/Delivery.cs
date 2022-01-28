using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackaged = false;

    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("DIO GANTENG");
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Paket"){
            Debug.Log("Paket telah diambil");
            hasPackaged = true;
        }
        if (other.tag == "Penerima" && hasPackaged){
            Debug.Log("DELIVERED");
            hasPackaged = false;
        }
    }
}
