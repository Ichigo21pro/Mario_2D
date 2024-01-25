using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostrarMenuTutorial : MonoBehaviour
{
    public CanvasGroup canvasGroup;

    void Start()
    {
        // Asegurarse de que el CanvasGroup esté inicialmente oculto al iniciar el juego
        canvasGroup.alpha = 0f;
        canvasGroup.blocksRaycasts = false;
        canvasGroup.interactable = false;
    }

    public void MostrarCanvas()
    {
        // Hacer visible el CanvasGroup al pulsar el botón
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        canvasGroup.interactable = true;
    }
}
