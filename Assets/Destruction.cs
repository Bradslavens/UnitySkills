using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour
{
    public float destroyIn = 1f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, destroyIn);
    }

}
