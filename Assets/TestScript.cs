using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public bool isDraggable = true;
    public bool isDragged = false;
    public Transform transform;


    // Update is called once per frame
    void Update()
    {
        if(isDragged){

            transform.position = Input.mousePosition;
        }
    }

    private void OnMouseOver() {
        if(isDraggable && Input.GetMouseButtonDown(0)){
            isDragged = true;
        }
        
    }

    private void OnMouseUp() {
        isDragged = false;
    } 

}
