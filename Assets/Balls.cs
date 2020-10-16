using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balls : MonoBehaviour
{
    public Rigidbody2D cannonBall;
    public Transform barrelPosition;

    private void Update() {
        if(Input.GetMouseButtonDown(0)){
            cannonBall.AddForce(barrelPosition.up *1000f);
        }
    }
}
