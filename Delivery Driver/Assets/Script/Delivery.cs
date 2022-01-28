using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Delivery : MonoBehaviour
{
    bool punyaPaket = false;
    [SerializeField] Color32 warnaAmbilPaket = new Color32 (1,1,1,1);
    [SerializeField] Color32 warnaDefault = new Color32 (1,1,1,1);
    [SerializeField] Text UItext;

    SpriteRenderer spriteRenderer;

    private void Awake() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Paket" && !punyaPaket){
            Debug.Log("Paket Telah Dipick Up");
            punyaPaket = true;
            Destroy(other.gameObject);
            spriteRenderer.color = warnaAmbilPaket;
            UItext.gameObject.SetActive(true);
            UItext.text = "Paket telah di pick up";
            Invoke("TurnOffGameobject", 3);
        }

        if (other.tag == "Penerima" && punyaPaket){
            Debug.Log("DELIVERD");
            punyaPaket = false;
            spriteRenderer.color = warnaDefault;
            UItext.gameObject.SetActive(true);
            UItext.text = "Paket telah diterima";
            Invoke("TurnOffGameobject", 3);
        }
    }

    void TurnOffGameobject(){
        UItext.gameObject.SetActive(false);
    }
}
