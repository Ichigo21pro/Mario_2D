using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VolverBoton : MonoBehaviour
{
    
    public void VolverAlMenuBoton()
    {
        SceneManager.LoadScene("Intro");
    }
}
