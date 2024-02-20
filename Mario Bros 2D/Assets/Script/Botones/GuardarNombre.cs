using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;



public class GuardarNombre : MonoBehaviour
{
    public TMP_InputField inputField;
    private string nombreAlmacenado;
    private Sqlite sqliteManager; // Asegúrate de tener una referencia al script SqliteManager

    void Start()
    {
        sqliteManager = FindObjectOfType<Sqlite>(); // Ajusta esto si la referencia al SqliteManager no está en el mismo objeto
    }

    public void AlmacenarNombreYContador()
    {
        // Verificar si el nombre es nulo o vacío
        if (string.IsNullOrEmpty(inputField.text))
        {
            nombreAlmacenado = "Vacio";
        }
        else
        {
            nombreAlmacenado = inputField.text;
        }

        // Obtener el contador del script MostrarContadorUI
        MostrarContadorUI mostrarContadorUI = FindObjectOfType<MostrarContadorUI>();
        int contador = mostrarContadorUI.CantidadContador();

        Debug.Log("Nombre almacenado: " + nombreAlmacenado + ", Contador: " + contador);
        Debug.Log(sqliteManager);

        // Insertar el nombre y el contador en la base de datos
        sqliteManager.InsertPlayerData(nombreAlmacenado, contador);
    }
}