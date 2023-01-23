using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDControl : MonoBehaviour
{
    public float forceAmt = 7;
    Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(0, 0, forceAmt);
        }
    }
}
