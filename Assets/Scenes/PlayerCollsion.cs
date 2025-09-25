using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter (Collision collisionInfo) 
    {
        if(collisionInfo.collider.tag == "Finish")
        {
            movement.enabled = false;
            Debug.Log("вы проиграли");
        }
    }
}
