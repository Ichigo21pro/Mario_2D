using UnityEngine;

public class Camera : MonoBehaviour
{
    public float verticalOffset = 2f; // Ajusta la posici�n vertical de la c�mara
    private Transform mario;
    public MarioController marioController;

    private void Awake()
    {
        mario = GameObject.FindWithTag("Player").transform;
    }

    private void LateUpdate()
    {
        Vector3 cameraPosition = transform.position;
        cameraPosition.x = mario.position.x;
        cameraPosition.y = mario.position.y + verticalOffset; // Ajusta la posici�n vertical
        // En el juego original la c�mara no vuelve a la izquierda, solo avanza hacia la derecha
        // cameraPosition.x = Mathf.Max(cameraPosition.x, mario.position.x);
        transform.position = cameraPosition;
    }
}

