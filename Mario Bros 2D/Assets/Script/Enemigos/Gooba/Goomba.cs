using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goomba : MonoBehaviour
{
    private bool isAlive;

    // Start is called before the first frame update
    void Start()
    {
        isAlive = true;
    }

    public void RecibirDaño() 
    {
        if (isAlive) {
            isAlive = false;
            Destroy(gameObject);
        }
    }

    public bool IsAlive()
    {
        return isAlive;
    }
}
