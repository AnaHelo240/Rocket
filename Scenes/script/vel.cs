using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vel : MonoBehaviour
{

    public Vector2 velocity; 

    void Start()
    {
        
    }

    void Update()
    {
        
        
    }

        void FixedUpdate(){
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = Quaternion.Euler(0,0,0) * velocity;
    }
}
