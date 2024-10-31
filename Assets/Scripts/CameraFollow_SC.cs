using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraFollow_SC : MonoBehaviour
{
    public CinemachineVirtualCamera virtualCamera;
    public Transform target;           // cinemachine target, ara� atanacak

    [Header("Camera Properties")]
    [SerializeField] private float followDistance = 10f; // kamera uzakl�g�
    [SerializeField] private float followHeight = 5f;    // kemara y�kseklik ayar�
    [SerializeField] private float cameraZoom = 5f;      // kamera yak�nl�g�
    [SerializeField] private float dampTime = 5f;        // kamera takip h�z�

    private CinemachineTransposer transposer;
    private CinemachineFramingTransposer framingTransposer;

    private void Start()
    {
        if (virtualCamera != null)
        {
            transposer = virtualCamera.GetCinemachineComponent<CinemachineTransposer>();
            framingTransposer = virtualCamera.GetCinemachineComponent<CinemachineFramingTransposer>();
        }
        if (transposer != null)
        {
            transposer.m_FollowOffset = new Vector3(0,followHeight,-followDistance);
        }
    }

    private void Update()
    {
        if (transposer != null && target != null)
        {
            transposer.m_FollowOffset = new Vector3(0, followHeight, -followDistance);
            virtualCamera.m_Lens.OrthographicSize = cameraZoom;
        }

        if (framingTransposer != null)
        {
            framingTransposer.m_XDamping = dampTime;
            framingTransposer.m_YDamping = dampTime;
        }
    }
}
