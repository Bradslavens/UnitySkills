using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    public float speed;

    private void Start() {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

        rigidbody2D.AddForce(movement * speed);
        
    }

}
