using UnityEngine;

public class FollowForPlayer : MonoBehaviour

{
    public Transform player;
    public Vector3 offset;

    void Start()

    {
        
    }

    void Update()

    {
        transform.position = player.position + offset ;
    }

}
