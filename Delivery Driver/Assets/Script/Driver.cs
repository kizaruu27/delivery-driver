using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float moveSpeed = 2f;
    [SerializeField] float turnSpeed = 10f;
    [SerializeField] float boost = 20f;
    [SerializeField] float slower = 20f;

    void FixedUpdate()
    {
        Move();
    }

    void Move(){
        float driverMove = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float driverTurn = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        transform.Translate(0, driverMove, 0);
        transform.Rotate(0, 0, -driverTurn);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Boost"){
            moveSpeed += boost;
            Invoke("slowMobil", 0.5f);
        }
    }

    void slowMobil(){
        moveSpeed -= slower;
    }
}
