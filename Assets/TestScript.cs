using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public Rigidbody2D bullet;
    public Transform barrelPosition;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Rigidbody2D bulletInstance;
            bulletInstance = Instantiate(bullet, barrelPosition.position, barrelPosition.rotation) as Rigidbody2D;
            bulletInstance.AddForce(barrelPosition.up * 1000f);
        }
    }
}
