using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListExample : MonoBehaviour
{
    public List<GameObject> enemies;

    // Start is called before the first frame update
    void Start()
    {
        // Add some enemies to the list
        enemies.Add(GameObject.Find("Enemy1"));
        enemies.Add(GameObject.Find("Enemy2"));
        enemies.Add(GameObject.Find("Enemy3"));

        // Loop through the list and print the names of the enemies
        foreach (GameObject enemy in enemies)
        {
            Debug.Log("Enemy name: " + enemy.name);
        }

        // Remove an enemy from the list
        enemies.Remove(GameObject.Find("Enemy2"));

        // Loop through the updated list and print the names of the enemies
        foreach (GameObject enemy in enemies)
        {
            Debug.Log("Enemy name: " + enemy.name);
        }
    }
}

