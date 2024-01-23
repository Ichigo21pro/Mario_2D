using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mundo1 : MonoBehaviour
{
    public void CambiarDeEscena(string nombreEscena)
    {
        SceneManager.LoadScene("mundo_1.1");
    }
}

