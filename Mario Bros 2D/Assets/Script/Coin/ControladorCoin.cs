using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ControladorCoin : MonoBehaviour
{
    public TextMeshProUGUI contadorText; // Asigna un objeto de tipo Text desde el inspector
    private int contador = 0;

    // Singleton Instance
    private static ControladorCoin instance;

    private void Awake()
    {
        // Singleton pattern
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // Si ya hay una instancia, destruir este objeto
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        // Recuperar el contador almacenado en PlayerPrefs
        contador = PlayerPrefs.GetInt("ContadorCoins", 0);

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

    private void OnDestroy()
    {
        // Guardar el contador en PlayerPrefs al destruirse el objeto
        PlayerPrefs.SetInt("ContadorCoins", contador);
        PlayerPrefs.Save();
    }
}