using Unity.Cinemachine;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{
    public CinemachineCamera FollowCamera;
    private bool checkCam1 = true;
    
    [SerializeField] private float viewCamera = 60f;


    public void AssignCamera(Transform target)
    {
        FollowCamera.Follow = target;
        FollowCamera.LookAt = target;
        FollowCamera.Priority = 2;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && checkCam1)
        {
            checkCam1 = false;
            FollowCamera.Priority = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Tab) && !checkCam1)
        {
            checkCam1 = true;
            FollowCamera.Priority = 0;
            Debug.Log("Camera Follow Disabled");
        }

        //nhấn phím 1 để phóng to camera
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            FollowCamera.Lens.FieldOfView = viewCamera + 20f;
            Debug.Log("dum cam");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            FollowCamera.Lens.FieldOfView = viewCamera - 20f;
            Debug.Log("thu cam");
        }



    }
}