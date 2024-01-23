using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlDeVida : MonoBehaviour
{
    private CrecerDisminuir crecerDisminuirScript;
    private bool puedeRecibirDanio = true;

    private void Start()
    {
        crecerDisminuirScript = GetComponent<CrecerDisminuir>();
    }
    public void RecibirDanio()
    {
        if (puedeRecibirDanio)
        {
            StartCoroutine(EjecutarConRetraso(2f));
        }
    }
    private IEnumerator EjecutarConRetraso(float segundos)
    {
        puedeRecibirDanio = false;

        if (crecerDisminuirScript.EstaArmaActiva())
        {
            crecerDisminuirScript.Crecer();
        }
        else if (crecerDisminuirScript.EstaCrecerActiva())
        {
            crecerDisminuirScript.Disminuir();
        }
        else if (crecerDisminuirScript.EstaDisminuirActiva())
        {
            Debug.Log("Has muerto");
        }

        yield return new WaitForSeconds(segundos);

        puedeRecibirDanio = true;
    }
}
