using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tp_pipe : MonoBehaviour
{

    public MarioController marioController; // Asegúrate de asignar la referencia de MarioController desde el Inspector
    public GameObject TP;

    private bool tocandose = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            tocandose = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            tocandose = false;
        }
    }

    private void Update()
    {
        if (tocandose && Input.GetKeyDown(KeyCode.DownArrow))
        {
            // Teleporta a Mario al TP2
            marioController.Teleport(TP.transform.position);
            Debug.Log("Se tepea");
        }
    }



}