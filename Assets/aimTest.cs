using UnityEngine;
using Unity.Cinemachine;
public class aimTest : MonoBehaviour
{
    public CinemachineCamera FolowCam;
    public CinemachineCamera Camera;

    bool usingCameraA = true;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SwitchingCam();
        }
    }

    void SwitchingCam()
    {
        usingCameraA = !usingCameraA;

        FolowCam.Priority = usingCameraA ? 1 : 0;
        Camera.Priority = usingCameraA ? 0 : 1;
    }
}
