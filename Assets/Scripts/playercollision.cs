using UnityEngine;

public class playercollision : MonoBehaviour
{
    public playermovement move;

    void OnCollisionEnter(Collision collisioninfo)
    {
        if(collisioninfo.collider.tag  == "obstacle")
        {
            move.enabled = false;
            FindObjectOfType<GameManager>().Endgame();
        }
    }
}
