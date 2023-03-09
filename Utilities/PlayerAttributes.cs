using UnityEngine;

public class PlayerAttributes : MonoBehaviour
{
    // The player's starting health
    public int startingHealth = 100;

    // The player's current health
    private int currentHealth;

    // The player's starting score
    public int startingScore = 0;

    // The player's current score
    private int currentScore;

    private void Start()
    {
        // Initialize the player's health and score
        currentHealth = startingHealth;
        currentScore = startingScore;
    }

    public void TakeDamage(int damage)
    {
        // Reduce the player's health by the specified amount
        currentHealth -= damage;

        // Check if the player has died
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        // Do something when the player dies, such as restarting the level or showing a game over screen
        Debug.Log("Player has died.");
    }

    public void AddScore(int score)
    {
        // Add the specified amount of score to the player's current score
        currentScore += score;
    }
}
