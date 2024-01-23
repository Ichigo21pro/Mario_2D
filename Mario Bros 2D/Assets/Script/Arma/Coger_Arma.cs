using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coger_Arma : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CrecerDisminuir controladorPlayer = other.GetComponent<CrecerDisminuir>();

            if (controladorPlayer != null)
            {
                controladorPlayer.Arma();
            }
            // Desactivar la seta al ser tocada
            gameObject.SetActive(false);

            
        }
    }
}
