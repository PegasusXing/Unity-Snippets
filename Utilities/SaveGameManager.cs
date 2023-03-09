using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveGameManager : MonoBehaviour
{
    // Define the data structure to be saved
    [System.Serializable]
    public class SaveData
    {
        public int currentLevel;
        public float health;
        public List<string> inventory;
        // add any other fields that you want to save
    }

    // The name of the save file
    private string saveFileName = "saveData.dat";

    // The current save data
    private SaveData currentSaveData = new SaveData();

    private void Awake()
    {
        LoadSaveData();
    }

    private void SaveGame()
    {
        // Save the current game state
        currentSaveData.currentLevel = LevelManager.currentLevel;
        currentSaveData.health = Player.health;
        currentSaveData.inventory = InventoryManager.GetInventory();

        // Serialize the data to binary format
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/" + saveFileName);
        bf.Serialize(file, currentSaveData);
        file.Close();
    }

    private void LoadSaveData()
    {
        // Load the save data from file
        if (File.Exists(Application.persistentDataPath + "/" + saveFileName))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/" + saveFileName, FileMode.Open);
            currentSaveData = (SaveData)bf.Deserialize(file);
            file.Close();

            // Restore the game state from the loaded data
            LevelManager.currentLevel = currentSaveData.currentLevel;
            Player.health = currentSaveData.health;
            InventoryManager.SetInventory(currentSaveData.inventory);
        }
    }
}
