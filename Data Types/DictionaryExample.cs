using System.Collections.Generic;  // Import the System.Collections.Generic namespace

public class DictionaryExample : MonoBehaviour {

    void Start() {

        // Create a dictionary to store data
        Dictionary<string, int> scoreDict = new Dictionary<string, int>();

        // Add data to the dictionary
        scoreDict.Add("Player 1", 100);
        scoreDict.Add("Player 2", 200);
        scoreDict.Add("Player 3", 150);

        // Access data in the dictionary using keys
        int player1Score = scoreDict["Player 1"];
        int player2Score = scoreDict["Player 2"];
        int player3Score = scoreDict["Player 3"];

        // Print out the scores
        Debug.Log("Player 1 score: " + player1Score);
        Debug.Log("Player 2 score: " + player2Score);
        Debug.Log("Player 3 score: " + player3Score);

        // Modify data in the dictionary
        scoreDict["Player 1"] = 50;

        // Remove data from the dictionary
        scoreDict.Remove("Player 2");

        // Check if a key exists in the dictionary
        bool hasPlayer2 = scoreDict.ContainsKey("Player 2");
        Debug.Log("Dictionary contains Player 2: " + hasPlayer2);

        // Loop through all the data in the dictionary
        foreach(KeyValuePair<string, int> pair in scoreDict) {
            Debug.Log(pair.Key + ": " + pair.Value);
        }
    }
}
