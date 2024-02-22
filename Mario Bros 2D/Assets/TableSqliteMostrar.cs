using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Sqlite;
using UnityEngine.UI;

public class TableSqliteMostrar : MonoBehaviour
{
    public GameObject playerPrefab;
    public VerticalLayoutGroup VerticalLayoutGroup;

    private Sqlite sqlite;

    void Start()
    {
        sqlite = FindObjectOfType<Sqlite>();
        DisplayPlayerData();
    }

    void DisplayPlayerData()
    {
        List<PlayerData> playerDataList = sqlite.GetPlayerData();

        foreach (PlayerData playerData in playerDataList)
        {
            // Crear visualmente un objeto para representar al jugador
            GameObject playerObject = Instantiate(playerPrefab, VerticalLayoutGroup.transform);

            // Configurar el objeto con los datos del jugador
            Text[] textFields = playerObject.GetComponentsInChildren<Text>();

            textFields[1].text = "Nombre: " + playerData.Nombre;
            textFields[2].text = "Score: " + playerData.Score;
        }
    }
}
