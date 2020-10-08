using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public GameObject square;
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Instantiate(square);
        }
    }
}
