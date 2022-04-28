using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed= 3f;
    
    public GameObject ballePrefab;

    [SerializeField]
    private float mouseSensitivity = 10f;
    
    private PlayerMotor motor;
    
    
    private void Awake() {
        Cursor.lockState = CursorLockMode.Locked;
    }
    
    private void Start()
    {
        motor = GetComponent<PlayerMotor>();

    }
    
    // Update is called once per frame
    private void Update()
    {
        
        float xMov = Input.GetAxisRaw("Horizontal");
        float zMov = Input.GetAxisRaw("Vertical");

        Vector3 moveHorizontal = transform.right * xMov;
        Vector3 moveVertical = transform.forward * zMov;

        Vector3 velocity = (moveHorizontal + moveVertical).normalized * speed;

        motor.Move(velocity);

        float yRot = Input.GetAxisRaw("Mouse X");

        Vector3 rotation = new Vector3(0, yRot, 0) * mouseSensitivity;

        motor.Rotate(rotation);
        
        float xRot = Input.GetAxisRaw("Mouse Y");

        Vector3 cameraRotation = new Vector3(xRot, 0, 0) * mouseSensitivity;

        motor.RotateCamera(cameraRotation);

    }
    
    
}
