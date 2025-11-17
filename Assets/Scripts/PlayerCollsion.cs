using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour 
{ 

public PlayerMovement movement;

void OnCollisionEnter(Collision collisionInfo) 
 { 

   if (collisionInfo.collider.tag == "Obstade") 
    { 
      movement.enabled = false; 
      Debug.Log("Вы проиграли.");
      SceneManager.LoadScene ("Main Restart");
    } 
 } 
}