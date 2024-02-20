using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mundo1 : MonoBehaviour
{
    public string escena = "mundo_1.1";
    public void CambiarDeEscena(string nombreEscena)
    {
        SceneManager.LoadScene(escena);
    }
}

