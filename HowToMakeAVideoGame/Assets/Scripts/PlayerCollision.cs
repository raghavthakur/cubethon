using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement; // reference to our PlayerMovement script

    // This method runs when we hit another object
    void OnCollisionEnter(Collision collisionInfo)
    {
        // chech to see if object collided with has tag called "Obstacle"
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;   // disable players movement
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
