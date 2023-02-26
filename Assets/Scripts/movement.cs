using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class movement : MonoBehaviour
{
    private Rigidbody2D rb;
    private BackgroundScroll[] backgrounds;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        backgrounds = FindObjectsOfType<BackgroundScroll>();
    }

    // Update is called once per frame
    private void Update()
    {
        float dirX = Input.GetAxis("Horizontal");
        rb.velocity = new UnityEngine.Vector2(dirX * 15f, rb.velocity.y); //velocity y is kept instead of resetting to zero and causing character to jump

        // Scroll every background.
        foreach(var bg in backgrounds)
        {
            bg.scroll(dirX);
        }

        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new UnityEngine.Vector2(rb.velocity.x, 20f);
        }
    }



}

