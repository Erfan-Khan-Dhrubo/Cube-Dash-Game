using System;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public playerMovement movement;
    
    public GameObject gameOverScreen;

    public newScore script;
    private bool _isdead = false;
 

    private void Update()
    {
        if (!_isdead)
        {
            if (transform.position.x > 8 || transform.position.x < -8)
            {
                script.playerDead = true;
                movement.enabled = false;
                gameOverScreen.SetActive(true);
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.collider.CompareTag("obj"))
        {
            script.playerDead = true;
            movement.enabled = false;
            gameOverScreen.SetActive(true);
        }

    }
    
}
