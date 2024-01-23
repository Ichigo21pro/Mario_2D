using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrecerDisminuir : MonoBehaviour
{
    public GameObject bigObject;
    public GameObject smallObject;
    public GameObject arma;

    private void Start()
    {
        // Al inicio, asegúrate de que solo uno de los objetos esté visible
        bigObject.SetActive(false);
        smallObject.SetActive(true);
        arma.SetActive(false);
    }

    public void Crecer()
    {
        bigObject.SetActive(true);
        smallObject.SetActive(false);
        arma.SetActive(false);
        
    }

    public void Disminuir()
    {
        smallObject.SetActive(true);
        bigObject.SetActive(false);
        arma.SetActive(false);
        
        
    }
    public void Arma()
    {
        arma.SetActive(true);
        bigObject.SetActive(false);
        smallObject.SetActive(false);
        
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
