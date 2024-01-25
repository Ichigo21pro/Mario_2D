using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ocultarmenututorial : MonoBehaviour
{
    public CanvasGroup canvasGroup;

    void Start()
    {
        // Asegurarse de que el CanvasGroup esté inicialmente visible al iniciar el juego
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        canvasGroup.interactable = true;
    }

    public void OcultarCanvas()
    {
        // Hacer invisible el CanvasGroup al pulsar el botón
        canvasGroup.alpha = 0f;
        canvasGroup.blocksRaycasts = false;
        canvasGroup.interactable = false;
    }
}
