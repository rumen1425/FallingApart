using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    private Material _material;
    private float _offset;

    // Individual background element scroll speed.
    public float speed = 0.1f;

    void Start()
    {
        // Save reference to Renderer's material so you only call GetComponent once.
        _material = GetComponent<Renderer>().material;
    }

    // <summary>
    // Get horizontal movement axis value (Positive or Negative) and scroll by a multiplied set amount.
    // </summary>
    // <param name="horizontal">Value from Input.GetAxis("Horizontal")</param>
    public void scroll(float horizontal)
    {
        // Get previous texture offset.
        _offset = _material.mainTextureOffset.x;

        // Multiply set speed by horizontal to apply scroll direction.
        // Multiply by Time.deltaTime to make background scrolling framerate-independent.
        _material.mainTextureOffset = new Vector2(_offset + (horizontal * speed * Time.deltaTime), 0); 
    }
}
