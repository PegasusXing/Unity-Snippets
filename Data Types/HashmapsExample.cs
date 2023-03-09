using System.Collections.Generic; // Required for using the Dictionary class

public class HashmapsExample : MonoBehaviour
{
    private Dictionary<string, int> inventory = new Dictionary<string, int>(); // Declare and initialize a new dictionary

    void Start()
    {
        // Add items to the inventory
        inventory.Add("Sword", 1);
        inventory.Add("Shield", 1);
        inventory.Add("Potion", 5);

        // Access items in the inventory using keys
        Debug.Log("You have " + inventory["Sword"] + " swords.");
        Debug.Log("You have " + inventory["Potion"] + " potions.");

        // Modify items in the inventory
        inventory["Potion"] = 10;
        Debug.Log("You now have " + inventory["Potion"] + " potions.");

        // Check if an item is in the inventory
        if (inventory.ContainsKey("Key"))
        {
            Debug.Log("You have a key.");
        }
        else
        {
            Debug.Log("You do not have a key.");
        }

        // Remove an item from the inventory
        inventory.Remove("Sword");
        Debug.Log("You no longer have a sword.");
    }
}
