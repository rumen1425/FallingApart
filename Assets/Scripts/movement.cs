using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    private Rigidbody2D rb;
    private BackgroundScroll[] backgrounds;
    private bool jump = true;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        backgrounds = FindObjectsOfType<BackgroundScroll>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("flag"))
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene(sceneName: "Main menu");
        }
    }

    // Update is called once per frame
    private void Update()
    {
        float dirX = Input.GetAxis("Horizontal");
        rb.velocity = new UnityEngine.Vector2(dirX * 15f, rb.velocity.y); //velocity y is kept instead of resetting to zero and causing character to jump

        // Scroll every background.
        foreach (var bg in backgrounds)
        {
            bg.scroll(dirX);
        }

        //prevents double jumping
        if (Input.GetButtonDown("Jump") && (jump == true))
        {
            rb.velocity = new UnityEngine.Vector2(rb.velocity.x, 20f);
            jump = false;
        }

        if (rb.velocity.y == 0)
        {
            jump = true;
        }
    }
}
