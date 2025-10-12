using UnityEngine;
public class PlayerCollision : MonoBehaviour 
{ 
 public PlayerMovement movement;
void OnCollisionEnter(Collision collisionInfo) 
 { 
    if (collisionInfo.collider.tag == "Enemy") 

    { 
            movement.enabled = false; 

            Debug.LogError("вы проиграли");

    } 
  } 
 }