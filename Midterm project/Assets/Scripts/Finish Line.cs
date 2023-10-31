using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Add any necessary variables and references here
    
    void Update()
    {
        // Implement player movement code here
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Finish Line")) // Change "Goal" to the tag you use for your goal object
        {
            // Player has reached the goal, stop the game
            Time.timeScale = 0f;
        }
    }
}
