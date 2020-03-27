using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleBehaviour : MonoBehaviour
{

    // I apologize for the messy code ^^

    public float tileSize; // Size of each tile of the grid
    bool movedX, movedY;

    void Start()
    {}

    void FixedUpdate()
    {
        if (Mathf.Round(Input.GetAxisRaw("Horizontal")) != 0)
        {
            if (!movedX)
            {
                transform.position = new Vector2(
                    transform.position.x + (Mathf.Sign(Input.GetAxisRaw("Horizontal")) * tileSize),
                    transform.position.y); // Mathf.Sign() returns -1 or 1 depending on pos/neg, so this here is to move 
                                           // the correct direction
            }
            movedX = true; // A boolean which checks if the player has released the "axis" since last time
        }
        else { movedX = false; } // This is to make sure that the player cannot hold down the key

        if (Mathf.Round(Input.GetAxisRaw("Vertical")) != 0)
        {
            if (!movedY)
            {
                transform.position = new Vector2(
                    transform.position.x,
                    transform.position.y + (Mathf.Sign(Input.GetAxisRaw("Vertical")) * tileSize)); // Identical but in y axis
                // Separate to ensure that holding down the right arrow (for example) will not cause the down arrow to not work
            }
            movedY = true; 
        }
        else { movedY = false; } 
    }
}
