using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moverse : MonoBehaviour
{

    public string tagDelJugador = "Player";
    public float velocidad = 5f;
    public string tagDeLaCamara = "MainCamera"; // Cambia esto al tag correcto de tu c�mara
    public Goomba goomba;

    private Transform player;
    private bool enContactoConCamara = false;
    private void Update()
    {
        if (enContactoConCamara) { MoverEnX(); }
           
        
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica si el collider tiene el tag de la c�mara
        if (other.CompareTag(tagDeLaCamara))
        {
            enContactoConCamara = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        // Verifica si el collider tiene el tag de la c�mara
        if (other.CompareTag(tagDeLaCamara))
        {
            enContactoConCamara = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Limit"))
        {
            Debug.Log("�Gooba se ha caido al vacio!");
            goomba.RecibirDa�o();

        }
    }



    private void MoverEnX()
    {
        // Encuentra el objeto con el tag "Player" al inicio
        player = GameObject.FindGameObjectWithTag(tagDelJugador).transform;

        if (player == null)
        {
            Debug.LogError("No se encontr� un objeto con el tag 'Player'");
        }

        // Verifica si se encontr� el objeto "Player"
        if (player != null)
        {
            // Calcula la direcci�n hacia el jugador
            Vector3 direction = player.position - transform.position;
            direction.Normalize();

            // Mueve el objeto en la direcci�n calculada
            transform.Translate(direction * velocidad * Time.deltaTime);
        }
    }

   
}
