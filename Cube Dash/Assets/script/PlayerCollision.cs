using System;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public playerMovement movement;

    public newScore script;
 

    private void Update()
    {
        if (transform.position.x > 8 || transform.position.x < -8)
        {
            script.playerDead = true;
            movement.enabled = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.collider.CompareTag("obj"))
        {
            script.playerDead = true;
            movement.enabled = false;
        }

    }
    
}
