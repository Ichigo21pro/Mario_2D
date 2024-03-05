using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;

public class Llegar_meta : MonoBehaviour
{
    public float velocidadBandera = 5f; // Velocidad en la dirección -x
    public float distanciaMaxima = 10f; // Distancia máxima en el eje -x
    public GameObject Bandera;
    private bool LlegoAMeta;
    public String escenaCambio ;
    public AudioSource Fin;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verificar si el jugador colisiona con un objeto con la etiqueta "Meta"
        if (collision.gameObject.CompareTag("Player"))
        {
            Fin.Play();

            LlegoAMeta = true;

            Invoke("CargarEscena", 3f);
        }

        
    }

    private void Update()
    {
        if (LlegoAMeta)
        {
            // Mover la Bandera en el eje -y con una velocidad limitada por la distancia máxima
            Bandera.transform.Translate(Vector2.down * velocidadBandera * Time.deltaTime);

            // Verificar si la Bandera ha alcanzado la distancia máxima en el eje -y
            if (Bandera.transform.position.y < (transform.position.y - distanciaMaxima))
            {
                Bandera.transform.position = new Vector2(Bandera.transform.position.x, transform.position.y - distanciaMaxima);

            }
        }
    }
    void CargarEscena()
    {
        SceneManager.LoadScene(escenaCambio);
    }

}
