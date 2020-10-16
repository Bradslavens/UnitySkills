using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balls : MonoBehaviour
{
    public Rigidbody2D cannonBall;
    public Transform barrelPosition;

    private void Update() {
        if(Input.GetMouseButtonDown(0)){
            Rigidbody2D cannonBallInstance;
            cannonBallInstance = Instantiate(cannonBall, barrelPosition.position, barrelPosition.rotation) as Rigidbody2D;
            cannonBallInstance.AddForce(barrelPosition.up *1000f);
        }
    }
}
