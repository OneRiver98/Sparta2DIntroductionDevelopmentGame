using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Camera mainCamera;
    [SerializeField]private Transform cameraTarget;


    private void Awake()
    {
        mainCamera = GetComponent<Camera>();
    }

    private void LateUpdate()
    {
        Vector3 cameraPosition = new Vector3(cameraTarget.position.x, cameraTarget.position.y, -10);
        mainCamera.transform.position = cameraPosition;
    }
}