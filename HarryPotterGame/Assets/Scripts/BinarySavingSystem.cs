using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;

public static class BinarySavingSystem // static - нам нужна всего одна копия этого класса
{
    public static void SavePlayer(HealthController healthController , Inventory inventory)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath +  "/player.b";
        FileStream stream = new FileStream(path, FileMode.OpenOrCreate);

        PlayerData data = new PlayerData(healthController,inventory);
        
        formatter.Serialize(stream, data);
        stream.Close();
    }
    
    public static PlayerData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/player.b";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();
            
            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }

}