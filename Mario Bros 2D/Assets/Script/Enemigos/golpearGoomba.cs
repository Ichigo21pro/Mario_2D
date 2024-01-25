using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class golpearGoomba : MonoBehaviour
{
    public Goomba goomba;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Eliminar el objeto pasado por parámetro
            if (goomba != null)
            {
                goomba.RecibirDaño();
            }

            // También puedes desactivar el script actual después de eliminar el objeto, si es necesario
            //gameObject.SetActive(false);
        }
    }
}
