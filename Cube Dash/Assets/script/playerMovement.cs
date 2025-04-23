using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rigidBody;
    public float moveSpeed = 2000;
    public float sideWalkSpeed = 500;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidBody.AddForce(0, 0, moveSpeed * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rigidBody.AddForce(sideWalkSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rigidBody.AddForce(-sideWalkSpeed * Time.deltaTime, 0, 0);
        }
    }
}
