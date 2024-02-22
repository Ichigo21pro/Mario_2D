using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Sqlite;
using UnityEngine.UI;
using TMPro;

public class TableSqliteMostrar : MonoBehaviour
{

    public VerticalLayoutGroup verticalLayoutGroup;
    public GameObject playerPrefab; // Tu prefab que contiene los dos TextMeshPro

    void Start()
    {
        DisplayPlayerTable();
    }

    void DisplayPlayerTable()
    {
        Sqlite sqliteScript = FindObjectOfType<Sqlite>();
        List<PlayerData> playerDataList = sqliteScript.ReadPlayerData();

        foreach (PlayerData playerData in playerDataList)
        {
            GameObject playerObject = Instantiate(playerPrefab, verticalLayoutGroup.transform);

            TextMeshProUGUI playerNameText = playerObject.transform.Find("nombre").GetComponent<TextMeshProUGUI>();
            playerNameText.text = playerData.playerName;

            TextMeshProUGUI playerScoreText = playerObject.transform.Find("puntuacion").GetComponent<TextMeshProUGUI>();
            playerScoreText.text = playerData.playerScore.ToString();
        }
    }
}
