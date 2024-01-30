using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverseBala : MonoBehaviour
{
    public float velocidad = 50f; // Velocidad de movimiento de la bala
    
    void Update()
    {
        // Mover la bala en el eje X
        transform.Translate(Vector3.right * velocidad * Time.deltaTime);
    }


 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision");
        if (!collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
          
        }
        

    }


  
}
