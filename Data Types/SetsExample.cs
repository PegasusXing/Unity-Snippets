using System.Collections.Generic;
using UnityEngine;

public class SetsExample : MonoBehaviour
{
    // Declare a set of integers
    private HashSet<int> mySet = new HashSet<int>();

    void Start()
    {
        // Add some elements to the set
        mySet.Add(1);
        mySet.Add(2);
        mySet.Add(3);

        // Check if an element is in the set
        if (mySet.Contains(2))
        {
            Debug.Log("2 is in the set!");
        }

        // Remove an element from the set
        mySet.Remove(1);

        // Iterate over the elements in the set
        foreach (int i in mySet)
        {
            Debug.Log(i);
        }

        // Clear the set
        mySet.Clear();
    }
}
