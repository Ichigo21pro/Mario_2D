using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AbrirMenuESC : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    private bool Estavisible;
   
    void Start()
    {
        // Asegurarse de que el CanvasGroup est� inicialmente oculto al iniciar el juego
        canvasGroup.alpha = 0f;
        canvasGroup.blocksRaycasts = false;
        canvasGroup.interactable = false;
        Estavisible = false;
       
    }
    private void Update()
    {
        // Hacer visible el CanvasGroup al pulsar el bot�n
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Tecla pulsada" + Estavisible);
            if (!Estavisible) MostrarInterfaz();
        }
    }

    public void BotonContinuar()
    {
        OcultarInterfaz();
    }

    public void OcultarInterfaz()
    {
        Estavisible = false;
        canvasGroup.alpha = 0f;
        canvasGroup.blocksRaycasts = false;
        canvasGroup.interactable = false;
        // Reanudar el tiempo cuando se cierra el CanvasGroup
        Time.timeScale = 1f;
    }

    public void MostrarInterfaz()
    {
        Estavisible = true;
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        canvasGroup.interactable = true;
        // Congelar el tiempo cuando se abre el CanvasGroup
        Time.timeScale = 0f;
    }

    public void BotonVolverMenu()
    {

        ////////////////////////////
        ///     GAME COIN       ///
        ///////////////////////////
        SceneManager.LoadScene("Intro");


    }
}
