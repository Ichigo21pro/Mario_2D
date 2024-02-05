using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrecerDisminuir : MonoBehaviour
{
    public GameObject bigObject;
    public GameObject smallObject;
    public GameObject arma;

    private CapsuleCollider2D CambioCollider;

    private void Start()
    {
        // Al inicio, asegúrate de que solo uno de los objetos esté visible
        bigObject.SetActive(false);
        smallObject.SetActive(true);
        arma.SetActive(false);

        CambioCollider = gameObject.GetComponent<CapsuleCollider2D>();
    }

    public void Crecer()
    {
        bigObject.SetActive(true);
        smallObject.SetActive(false);
        arma.SetActive(false);


        CambioCollider.size = new Vector2(1f, 2f);
        CambioCollider.offset = new Vector2(0f, 0f);
    }

    public void Disminuir()
    {
        smallObject.SetActive(true);
        bigObject.SetActive(false);
        arma.SetActive(false);

        CambioCollider.size = new Vector2(1f, 1f);
        CambioCollider.offset = new Vector2(0f, -0.5f);
    }
    public void Arma()
    {
        arma.SetActive(true);
        bigObject.SetActive(false);
        smallObject.SetActive(false);

        CambioCollider.size = new Vector2(1f, 2f);
        CambioCollider.offset = new Vector2(0f, 0f);
    }

    public bool EstaArmaActiva()
    {
        // Devuelve true si el objeto de arma está activo, de lo contrario, devuelve false
       
        return arma.activeSelf;
    }

    public bool EstaCrecerActiva()
    {
        // Devuelve true si el objeto de arma está activo, de lo contrario, devuelve false
        return bigObject.activeSelf;
    }

    public bool EstaDisminuirActiva()
    {
        // Devuelve true si el objeto de arma está activo, de lo contrario, devuelve false
        return smallObject.activeSelf;
    }
}
