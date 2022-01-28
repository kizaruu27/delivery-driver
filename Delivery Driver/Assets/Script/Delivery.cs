using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackaged = false;
    [SerializeField] float destroyTime = 1f;
    [SerializeField] Color32 hasPackagedColor = new Color32 (1,1,1,1);
    [SerializeField] Color32 noPackageColor = new Color32 (1,1,1,1);
   

    SpriteRenderer spriteRenderer;

    private void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("DIO GANTENG");
    }

    private void OnTriggerEnter2D(Collider2D other) {

        if(other.tag == "Paket" && !hasPackaged){
            Debug.Log("Paket telah diambil");
            hasPackaged = true;

            //ubah warna ambil paket
            spriteRenderer.color = hasPackagedColor;

            Destroy(other.gameObject, destroyTime);
        }

        if (other.tag == "Penerima" && hasPackaged){
            Debug.Log("DELIVERED");
            spriteRenderer.color = noPackageColor;
            hasPackaged = false;
            //ubah warna ke default
        }
    }
}
