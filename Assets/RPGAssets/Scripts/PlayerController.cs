using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        float speed = 4.0f;
        rb.velocity = new Vector2(Input.GetAxis("Horizontal"),
       Input.GetAxis("Vertical")) * speed;
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("xspeed", rb.velocity.x);
        anim.SetFloat("yspeed", rb.velocity.y);
        //if (rb.velocity.magnitude < 0.01)
            //anim.speed = 0.0f;
        //else
            //anim.speed = 1.0f;
    }
}
