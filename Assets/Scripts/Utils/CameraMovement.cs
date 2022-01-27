    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMovement : MonoBehaviour
{

    public float mouseSensitivity = 100f;

    public Transform playerBody;
    Controls controls;

    float xRotation = 0f;
    void Awake()
    {
        controls = new Controls();
    }

    void Start() {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update() {
        
    }

    public void CameraMove(Vector2 camera)
    {
        float x = camera.x * mouseSensitivity * Time.deltaTime;
        float y = camera.y * mouseSensitivity * Time.deltaTime;

        xRotation -= y;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * x);
    }
}
