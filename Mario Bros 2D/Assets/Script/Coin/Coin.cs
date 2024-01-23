using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verificar si el objeto que ha colisionado tiene la etiqueta "Player"
        if (other.CompareTag("Player"))
        {
            // Obtener el script del objeto Empty y aumentar el contador
            ControladorCoin emptyScript = FindObjectOfType<ControladorCoin>();
            if (emptyScript != null)
            {
                emptyScript.AumentarContador();
            }

            // Desaparecer la moneda
            Destroy(gameObject);
        }
    }
}
