using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform startMarker; // Reference to the start position GameObject

    private Vector3 initialPosition; // Store the initial position of the player

    private void Start()
    {
        if (startMarker != null)
        {
            initialPosition = startMarker.position; // Store the initial position
            Respawn();
        }
        else
        {
            Debug.LogError("Start position marker is not set for the player.");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Respawn();
        }
    }

    private void Respawn()
    {
        if (startMarker != null)
        {
            transform.position = initialPosition; // Reset the player to the initial position
            Debug.Log("Player respawned.");
        }
        else
        {
            Debug.LogError("Start position marker is not set for the player.");
        }
    }
}