using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonController : MonoBehaviour
{ 
    public Rigidbody2D canon;
    public float rotationSpeed = 50f;

    private void Start() {
        canon.gravityScale = 0;
    }

    private void Update() {
        var x = Input.GetAxis("Vertical") * Time.deltaTime * rotationSpeed;
        transform.Rotate(0,0,x);
    }

    private void FixedUpdate() {
        // canon.MoveRotation(canon.rotation + rotationSpeed + Time.fixedDeltaTime);
    }
}
