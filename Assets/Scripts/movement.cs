using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    int health = 3;
    bool jump = false;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        float directionX = Input.GetAxis("Horizontal");
        rb.velocity = new UnityEngine.Vector2(directionX * 15f, rb.velocity.y); //velocity y is kept instead of resetting to zero and causing character to jump

        if (Input.GetButtonDown("Jump") && (jump == false))
        {
            rb.velocity = new UnityEngine.Vector2(rb.velocity.x, 20f);
            jump = true;
        }

        if (rb.velocity.y == 0)
        {
            jump = false;
        }
    }
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("mobs"))
    //    {
    //        health -= 1; 
    //    }
    //}
}