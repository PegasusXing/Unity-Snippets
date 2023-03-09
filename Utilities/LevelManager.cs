using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // The current level number
    public static int currentLevel = 1;

    // The total number of levels in the game
    public int totalLevels = 3;

    private void Start()
    {
        // Load the current level
        LoadLevel(currentLevel);
    }

    public void LoadNextLevel()
    {
        // Load the next level
        currentLevel++;
        if (currentLevel > totalLevels)
        {
            // The player has completed the game, show a win screen or return to main menu
            SceneManager.LoadScene("WinScreen");
        }
        else
        {
            LoadLevel(currentLevel);
        }
    }

    public void ReloadLevel()
    {
        // Reload the current level
        LoadLevel(currentLevel);
    }

    private void LoadLevel(int level)
    {
        // Load the specified level
        SceneManager.LoadScene("Level" + level);
    }
}
