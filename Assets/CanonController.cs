using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonController : MonoBehaviour
{
    public Rigidbody2D canon;
    public float rotationSpeed = 0.5f;

    private Vector2 movPos;



    private void Start() {
        canon.gravityScale = 0;
    }

    private void Update() {
        // var x = Input.GetAxis("Vertical") * Time.deltaTime * rotationSpeed;
        // transform.Rotate(0,0,x);

        movPos.x = Input.GetAxis("Horizontal");
        movPos.y = Input.GetAxis("Vertical");
    }

    private void FixedUpdate() {
        // canon.MoveRotation(canon.rotation + rotationSpeed + Time.fixedDeltaTime);
        canon.MovePosition(canon.position + movPos * rotationSpeed * Time.fixedDeltaTime);
    }
}
