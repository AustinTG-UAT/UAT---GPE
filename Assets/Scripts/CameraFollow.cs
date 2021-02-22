using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // public target to allow designers to change the camera's target to focus on following
    public Transform CameraTarget;

    public float smoothSpeed = 0.125f;
    // offset set to public to allow Designers to change the offset from pawn
    public Vector3 offset;

    // Update camera position after all updates are called
    private void LateUpdate()
    {
        // location position for camera to follow by adding the targets vector position to the offset position (set by the designer)
        Vector3 needPos = CameraTarget.position + offset;
        // create vector3 variable to hold new location data for camera to follow pawn
        Vector3 smoothPos = Vector3.Lerp(transform.position, needPos, smoothSpeed);
        // move camera to new target position by changing cameras current position to new position identified by smoothPos
        transform.position = smoothPos;
    }
}
