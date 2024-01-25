using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ControladorCoin : MonoBehaviour
{
    public TextMeshProUGUI contadorText; // Asigna un objeto de tipo Text desde el inspector
    private int contador = 0;

    private void Start()
    {
        ActualizarContadorUI();
    }

    public void AumentarContador()
    {
        contador++;
        ActualizarContadorUI();
    }

    private void ActualizarContadorUI()
    {
        // Actualizar el texto del contador en la interfaz de usuario (UI)
        if (contadorText != null)
        {
            contadorText.text = "Monedas: " + contador;
        }
    }
}
