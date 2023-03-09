using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    // A list of all the items the player can pick up
    public List<Item> items;

    // The maximum number of items the player can carry at once
    public int maxItems = 10;

    // A reference to the player's inventory UI
    public InventoryUI inventoryUI;

    // The player's current inventory
    private List<Item> inventory = new List<Item>();

    private void Start()
    {
        // Initialize the inventory UI
        inventoryUI.SetInventoryManager(this);
    }

    public bool AddItem(Item item)
    {
        // Check if the player has reached the maximum number of items
        if (inventory.Count >= maxItems)
        {
            Debug.Log("Inventory is full.");
            return false;
        }

        // Add the item to the player's inventory
        inventory.Add(item);

        // Update the inventory UI
        inventoryUI.UpdateInventory();

        return true;
    }

    public void RemoveItem(Item item)
    {
        // Remove the item from the player's inventory
        inventory.Remove(item);

        // Update the inventory UI
        inventoryUI.UpdateInventory();
    }

    public bool HasItem(Item item)
    {
        // Check if the player has the specified item in their inventory
        return inventory.Contains(item);
    }
}
