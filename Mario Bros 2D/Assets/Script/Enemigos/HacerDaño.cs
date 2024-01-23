using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HacerDaño : MonoBehaviour
{


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // Asegúrate de que el collider del jugador tenga el tag adecuado
        {
            ControlDeVida controlDeVidaScript = collision.gameObject.GetComponent<ControlDeVida>();

            if (controlDeVidaScript != null)
            {
                controlDeVidaScript.RecibirDanio();
            }
        }
    }

}
