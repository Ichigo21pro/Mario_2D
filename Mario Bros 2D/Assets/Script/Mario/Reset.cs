using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Verificar si el jugador colisiona con un objeto con la etiqueta "Limit"
        if (collision.gameObject.CompareTag("Limit"))
        {
            Debug.Log("¡Has muerto!");
            // Reiniciar el juego
            RestartGame();
        }

    }
   
    

private void RestartGame()
    {
        // Puedes cargar la escena actual para reiniciar el juego
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
