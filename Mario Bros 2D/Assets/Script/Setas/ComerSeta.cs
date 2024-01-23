using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComerSeta : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CrecerDisminuir controladorPlayer = other.GetComponent<CrecerDisminuir>();

            if (controladorPlayer != null)
            {
                // Verificar si el arma está activada antes de permitir que el jugador crezca
                if (!controladorPlayer.EstaArmaActiva())
                {
                    controladorPlayer.Crecer();
                    // eliminar seta al ser comida
                    gameObject.SetActive(false);
                }
            }
        }
    }
}




