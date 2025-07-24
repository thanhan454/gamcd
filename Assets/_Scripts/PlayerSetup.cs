using Fusion;
using UnityEngine;

public class PlayerSetup : NetworkBehaviour
{
    public void SetupCamera()
    {
        var cameraFollow = FindFirstObjectByType<CameraFollowScript>();
        if (cameraFollow != null)
        {
            cameraFollow.AssignCamera(transform);
        }
    }
}