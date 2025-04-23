using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public playerMovement movement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    // Update is called once per frame
    
    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.collider.CompareTag("obj"))
        {
            Debug.Log("hello");
            movement.enabled = false;
        }

    }
    
}
