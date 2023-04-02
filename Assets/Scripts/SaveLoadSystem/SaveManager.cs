using UnityEngine;
using System.IO;

public static class SaveManager
{
    public static string directory = "/SaveData/";
    public static string fileName = "MyData.txt";

    public static void Save(PlayerLives so)
    {
        string dir = Application.persistentDataPath + directory;

        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }

        string json = JsonUtility.ToJson(so);
        File.WriteAllText(dir + fileName, json);
    }
    public static PlayerLives Load()
    {
        string fullPath = Application.persistentDataPath + directory + fileName;
        PlayerLives so = new PlayerLives();

        if(File.Exists(fullPath))
        {
            string json = File.ReadAllText(fullPath);
            so = JsonUtility.FromJson<PlayerLives>(json);
        }
        else
        {
            Debug.Log("Save file does not exist");
        }
        return so;
    }
}