using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemcollector : MonoBehaviour
{
    private int coins = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("coins"))
        {
            Destroy(collision.gameObject);
            coins++;
            Debug.Log("Coins: " + coins);
        }
    }
}
