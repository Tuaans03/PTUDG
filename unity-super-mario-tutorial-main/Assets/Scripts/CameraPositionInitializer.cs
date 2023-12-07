using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraPositionInitializer : MonoBehaviour
{
    public Vector3 defaultPosition = new Vector3(0f, 0f, -10f); // Vị trí mặc định của Camera
    private CinemachineVirtualCamera virtualCamera;

    void Start()
    {
        // Lấy tham chiếu đến CinemachineVirtualCamera từ trình điều khiển trình xem chính
        virtualCamera = GetComponent<CinemachineVirtualCamera>();

        // Đảm bảo virtualCamera không null và có tham chiếu đến tham số của trình xem 2D
        if (virtualCamera != null && virtualCamera.m_Lens.Orthographic)
        {
            // Thiết lập vị trí mặc định của Camera
            virtualCamera.transform.position = defaultPosition;
        }
        else
        {
            Debug.LogError("CinemachineVirtualCamera is not configured for 2D Orthographic projection.");
        }
    }
}
