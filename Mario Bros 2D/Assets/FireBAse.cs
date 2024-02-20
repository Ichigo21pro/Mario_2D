
/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Firebase.Database;
using JetBrains.Annotations;



[Serializable]
public class dataToSave {

    public string userName;
    public int TotalCoins;
}
public class DataSaver : MonoBehaviour
{

    public dataToSave dts;
    public string userID;
    DatabaseReference databaseReference;

    private void Awake()
    {
        databaseReference = FirebaseDatabase.DefaultInstance.RootReference;
    }

    public void SaveDataFn()
    {
        string json = JsonUtility.ToJson(dts);
        databaseReference.Child("users").Child(userID).SetRawJsonValueAsync(json);
    }
    public void LoadDataFn()
    {
        StartCoroutine(LoadDataEnum());
    }

    IEnumerator LoadDataEnum()
    {
        var serverData = databaseReference.Child("users").Child(userID).GetValueAsync();
        yield return new WaitUntil(predicate: () => serverData.IsCompleted);

        print("proceso terminado");
        DataSnapshot snapshot = serverData.Result;
        string jsonData = snapshot.GetRawJsonValue();

        if (jsonData != null)
        {
            print("Base de datos encontrada");
            dts = JsonUtility.FromJson<dataToSave>(jsonData);
        }
        else { 
            print("no se ha encontrado base de datos");
        }
    }
}

*/