using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform playerPos;
    void Update()
    {
        transform.position = new Vector3(playerPos.position.x, playerPos.position.y, -10);
    }
}
