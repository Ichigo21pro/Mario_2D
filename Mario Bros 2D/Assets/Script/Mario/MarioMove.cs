using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioController : MonoBehaviour
{
    private Rigidbody2D marioRigidbody;
    private bool canJump;
    public float moveSpeed = 5f;
    public float jumpForce = 10f;

    private bool teleported;
 

    void Start()
    {
        marioRigidbody = GetComponent<Rigidbody2D>();
        canJump = false;
    }

    void Update()
    {
        // Movimiento horizontal
        float horizontalInput = Input.GetAxis("Horizontal");
        Move(horizontalInput);

        // Salto solo si puede saltar (está en el suelo)
        if (canJump && Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

     


    }

    void Move(float horizontalInput)
    {
        Vector2 movement = new Vector2(horizontalInput * moveSpeed, marioRigidbody.velocity.y);
        marioRigidbody.velocity = movement;
    }

    void Jump()
    {
        marioRigidbody.velocity = new Vector2(marioRigidbody.velocity.x, jumpForce);
        canJump = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Verificar si el jugador está en contacto con cualquier otro collider
        canJump = true;
    }


    //////////////////////////////////////////////////////////////////////
    ///Para controlar el TP en las tuberias
    public void Teleport(Vector3 targetPosition)
    {
        transform.position = targetPosition;
    }
    //////////////////////////////////////////////////////////////////////
  
    
}





