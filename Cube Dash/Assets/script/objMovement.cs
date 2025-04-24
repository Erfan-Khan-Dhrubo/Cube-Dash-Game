using UnityEngine;

public class objMovement : MonoBehaviour
{
    public float moveSpeed = 10;
    public float deadZone = -50;
    
    
    // Update is called once per frame
    void Update()
    {
        transform.position +=  (new Vector3(0, 0, -1) * (moveSpeed * Time.deltaTime));
        // if (transform.position.x < deadZone)
        // {
        //     Destroy(gameObject);
        // }
        
    }
}
