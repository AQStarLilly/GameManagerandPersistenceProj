using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public static GameControl control;

    public float health;
    public float experience;
    public float score;
    public float level;
    public float bond;
    public float currency;

    void Awake()
    {
        if (control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this;
        }
        else if (control != this)
        {
            Destroy(gameObject);
        }
    }

    void OnGUI() //Print stats to screen
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
            return;

        GUI.Label(new Rect(10, 10, 100, 30), "Health: " + health);
        GUI.Label(new Rect(10, 25, 150, 30), "Experience: " + experience);
        GUI.Label(new Rect(10, 40, 150, 30), "Score: " + score);
        GUI.Label(new Rect(10, 55, 150, 30), "Level: " + level);
        GUI.Label(new Rect(10, 70, 150, 30), "Bond: " + bond);
        GUI.Label(new Rect(10, 85, 150, 30), "Currency: " + currency);
    }

    public void Save() //Method to save "Player" Stats
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");

        PlayerData data = new PlayerData();
        data.health = health;
        data.experience = experience;
        data.score = score;
        data.level = level;
        data.bond = bond;
        data.currency = currency;

        bf.Serialize(file, data);
        file.Close();
    }

    public void Load() //Method to load "Player" Stats
    {
        if (File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

            health = data.health;
            experience = data.experience;
            score = data.score;
            level = data.level;
            bond = data.bond;
            currency = data.currency;
        }
    }
}

[Serializable]
class PlayerData
{
    public float health;
    public float experience;
    public float score;
    public float level;
    public float bond;
    public float currency;
}