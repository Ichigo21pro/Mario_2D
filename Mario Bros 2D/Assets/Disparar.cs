using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public GameObject objetoADisparar;  // Objeto que se disparar�

    public void DispararBala()
    {
        // Crea una instancia del objeto a disparar en la posici�n de la pistola
        Instantiate(objetoADisparar, transform.position, Quaternion.identity);
    }
}
