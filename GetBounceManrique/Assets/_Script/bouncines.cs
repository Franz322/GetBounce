using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouncines : MonoBehaviour
{
    Rigidbody2D rb;
    float bounceForce = 20f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
   
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.contacts.Length > 0)
        {
            Vector2 bounce = Vector2.up * bounceForce;
            rb.velocity = new Vector2(rb.velocity.x, 0);
            rb.AddForce(bounce, ForceMode2D.Impulse); // .Force .Impulse .Acceleration .VelocityChange
        }



    }


}
