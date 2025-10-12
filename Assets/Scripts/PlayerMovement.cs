using UnityEngine;

public class PlayerMovement : MonoBehaviour

{ 
    public  Rigidbody    rb;

    public float forwardForce;

    void Start()

    {
        
    }

    void FixedUpdate()
    {   
         //скорость скольжения игрока.

         rb.AddForce( 0, 0, forwardForce * Time.deltaTime);
        //управление
         if  (Input.GetKey("d"))
         {

          rb.AddForce ( 600 * Time.deltaTime ,0 ,0 ); 

         }

         if  (Input.GetKey("a"))
         {

          rb.AddForce ( -600 * Time.deltaTime ,0 ,0 ); 

         }

    }
}
