using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    private Rigidbody2D rigibody2D;
    public float speed;

    private void Start() {
        rigibody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

        rigibody2D.AddForce(movement * speed);


    }
}
