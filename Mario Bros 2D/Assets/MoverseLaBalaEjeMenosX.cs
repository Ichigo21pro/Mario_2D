using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverseLaBalaEjeMenosX : MonoBehaviour
{
    public float velocidad = 15f; // Velocidad de movimiento de la bala
    private Rigidbody2D rb;

    void Update()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-velocidad, 0); // Cambi� "velocidad" a "-velocidad"
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision != null) { Destroy(gameObject); }
    }
}
