
using UnityEngine;

public class collision : MonoBehaviour
{
    public PLAYERMOVEMENT movement;

    void OnCollisionEnter (Collision collisionInfo)
    {
        if(collisionInfo.collider.tag =="Obstacle")
        {
            movement.enabled = false;
        }

    }





}


