using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecibirDisparo : MonoBehaviour
{
    public Goomba goomba;


  
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bull"))
        {
            // Eliminar el objeto pasado por par�metro
           
                goomba.RecibirDa�o();
            

            // Tambi�n puedes desactivar el script actual despu�s de eliminar el objeto, si es necesario
            //gameObject.SetActive(false);
        }
    }
}
