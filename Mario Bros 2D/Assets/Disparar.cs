using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public GameObject objetoADisparar;  // Objeto que se disparará

    public void DispararBala()
    {
        // Crea una instancia del objeto a disparar en la posición de la pistola
        Instantiate(objetoADisparar, transform.position, Quaternion.identity);
    }
}
