using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StacksExample : MonoBehaviour
{
    // Declare a stack to hold integers
    private Stack<int> myStack = new Stack<int>();

    void Start()
    {
        // Push integers onto the stack
        myStack.Push(3);
        myStack.Push(7);
        myStack.Push(1);
        myStack.Push(9);

        // Print the contents of the stack
        PrintStack();

        // Pop an element off the stack
        int poppedValue = myStack.Pop();
        Debug.Log("Popped value: " + poppedValue);

        // Print the contents of the stack again
        PrintStack();
    }

    void PrintStack()
    {
        // Create a string to hold the stack contents
        string stackContents = "Stack contents: ";

        // Loop through the stack and add each element to the string
        foreach (int i in myStack)
        {
            stackContents += i + " ";
        }

        // Print the string to the console
        Debug.Log(stackContents);
    }
}
