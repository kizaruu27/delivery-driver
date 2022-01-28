using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    [SerializeField] GameObject objectToFollow;
    float cameraOffset = -10f;

    // Update is called once per frame
    void LateUpdate()
    {
        cameraMove();
    }

    void cameraMove(){
        transform.position = objectToFollow.transform.position + new Vector3 (0,0,cameraOffset);
    }
}
