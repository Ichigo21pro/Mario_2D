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
    public Disparar bull;
    private CrecerDisminuir EstaConArma;

    void Start()
    {
        marioRigidbody = GetComponent<Rigidbody2D>();
        canJump = false;
        EstaConArma = GetComponent<CrecerDisminuir>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Move(horizontalInput);

        if (canJump && Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (EstaConArma != null && EstaConArma.EstaArmaActiva())
            {
                if (transform.localScale.x < 0)
                {
                    // Mirando hacia la izquierda, realiza la acción correspondiente
                    bull.DispararBalaMenosX();
                }
                else if (transform.localScale.x > 0)
                {
                    // Mirando hacia la derecha, realiza la acción correspondiente
                    bull.DispararBala();
                }
            }
        }
    }

    void Move(float horizontalInput)
    {
        Vector2 movement = new Vector2(horizontalInput * moveSpeed, marioRigidbody.velocity.y);
        marioRigidbody.velocity = movement;

        // Verificar la dirección del movimiento y ajustar la rotación
        if (horizontalInput < 0)
        {
            // Gira 180 grados si se mueve a la izquierda
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (horizontalInput > 0)
        {
            // Restablece la escala si se mueve a la derecha
            transform.localScale = new Vector3(1, 1, 1);
        }
    }

    void Jump()
    {
        marioRigidbody.velocity = new Vector2(marioRigidbody.velocity.x, jumpForce);
        canJump = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        canJump = true;
    }

    public void Teleport(Vector3 targetPosition)
    {
        transform.position = targetPosition;
    }
}
