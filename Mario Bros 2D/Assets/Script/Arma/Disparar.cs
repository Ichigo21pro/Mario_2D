using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public GameObject objetoADispararEjeX;  // Objeto que se disparar�
    public GameObject objetoADispararEjeMenosX;  // Objeto que se disparar�
    public void DispararBala()
    {
        // Obtener la posici�n del collider2D
        Collider2D myCollider = GetComponent<Collider2D>();
        if (myCollider != null)
        {
            Vector3 posicionDisparo = new Vector3(myCollider.bounds.center.x, myCollider.bounds.center.y, transform.position.z);

            // Crea una instancia del objeto a disparar en la posici�n del collider2D
            Instantiate(objetoADispararEjeX, posicionDisparo, Quaternion.identity);
        }
        else
        {
            Debug.LogError("El objeto no tiene un Collider2D adjunto.");
        }
    }
    public void DispararBalaMenosX()
    {
        // Obtener la posici�n del collider2D
        Collider2D myCollider = GetComponent<Collider2D>();
        if (myCollider != null)
        {
            Vector3 posicionDisparo = new Vector3(myCollider.bounds.center.x, myCollider.bounds.center.y, transform.position.z);

            // Crea una instancia del objeto a disparar en la posici�n del collider2D
            Instantiate(objetoADispararEjeMenosX, posicionDisparo, Quaternion.identity);
        }
        else
        {
            Debug.LogError("El objeto no tiene un Collider2D adjunto.");
        }
    }
}