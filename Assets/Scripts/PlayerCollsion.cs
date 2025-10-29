using UnityEngine;
public class PlayerCollision : MonoBehaviour 
{ 

public PlayerMovement movement;

void OnCollisionEnter(Collision collisionInfo) 
 { 

   if (collisionInfo.collider.tag == "Obstade") 
    { 
      movement.enabled = false; 
      Debug.LogError("вы проиграли");
    } 
 } 
}