using UnityEngine;
public class PlayerCollision : MonoBehaviour
{
    void onCollisionEnter (PlayerCollision collisionInfo)
    {
        Debug.Log(GetComponent<Collider>());
    }
}
