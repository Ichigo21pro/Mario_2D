using TMPro;
using UnityEngine;

public class MostrarContadorUI : MonoBehaviour
{
    public TextMeshProUGUI contadorText;
    int contador;

    // Start is called before the first frame update
    void Start()
    {
        MostrarContador();
    }

    private void MostrarContador()
    {
        // Verificar si el script ControladorCoin existe en la escena actual
        ControladorCoin controladorCoin = FindObjectOfType<ControladorCoin>();

        if (controladorCoin != null && contadorText != null)
        {
            // Obtener el contador del script ControladorCoin
            contador = controladorCoin.ObtenerContador();
      

            // Mostrar el contador en el TextMeshProUGUI
            contadorText.text = "" + contador;
        }
    }

    public int CantidadContador()
    {
        return contador;
    }
}