using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueExample : MonoBehaviour
{
    // Declare a queue of integers
    Queue<int> myQueue = new Queue<int>();

    void Start()
    {
        // Add some elements to the queue
        myQueue.Enqueue(1);
        myQueue.Enqueue(2);
        myQueue.Enqueue(3);

        // Print out the elements in the queue
        Debug.Log("Queue elements:");
        foreach (int element in myQueue)
        {
            Debug.Log(element);
        }

        // Remove the first element from the queue and print it out
        int firstElement = myQueue.Dequeue();
        Debug.Log("Removed element: " + firstElement);

        // Print out the remaining elements in the queue
        Debug.Log("Queue elements after dequeue:");
        foreach (int element in myQueue)
        {
            Debug.Log(element);
        }
    }
}
