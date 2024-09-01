using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    public float Movespeed = 5f;
    public float deadEndY;
    public Transform startPoint;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movement = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2 (movement * Movespeed, rb.velocity.y);
        if (transform.position.y < deadEndY)
        {
            transform.position = startPoint.position;
        }
    }
}
