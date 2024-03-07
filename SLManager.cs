using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SLManager
{
    public static void Save(int money)
    {
        Debug.Log("Hello im saving data :D");
        string dataPath = Application.persistentDataPath + "/money.save";
        FileStream fileStream = new FileStream(dataPath, FileMode.Create);
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        binaryFormatter.Serialize(fileStream, money);
        fileStream.Close();

    }

    public static int Load()
    {
        Debug.Log("Hello im loading data :D");
        string dataPath = Application.persistentDataPath + "/money.save";
        if (File.Exists(dataPath))
        {
            FileStream fileStream = new FileStream(dataPath, FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            int money = (int) binaryFormatter.Deserialize(fileStream);
            fileStream.Close();
            return money;
        }
        else
        {
            return 0;
        }
    }
}
