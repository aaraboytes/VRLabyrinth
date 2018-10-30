using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour {
    public float sensitivity,rayLimit;
    public Transform playerBody;

    float xAxisClamp = 0;
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position, transform.forward * rayLimit + transform.position);
    }
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
        xAxisClamp += mouseY;
        if(xAxisClamp >90f)
        {
            xAxisClamp = 90f;
            mouseY = 0;
            ClampXAxisRotToValue(270.0f);
        }else if(xAxisClamp <-90f)
        {
            xAxisClamp = -90f;
            mouseY = 0;
            ClampXAxisRotToValue(90.0f);
        }
        transform.Rotate(Vector3.left * mouseY);
        playerBody.Rotate(Vector3.up * mouseX);
        Ray ray = new Ray(transform.position, transform.forward * rayLimit);
        RaycastHit hit;
        if(Physics.Raycast(ray,out hit))
        {
            if (Input.GetMouseButton(0))
            {
                Debug.Log("Collision with" + hit.collider.name);
            }
            if (hit.collider.CompareTag("Interactive"))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Debug.Log("Action is going to be executed");
                    InteractiveObject io = hit.collider.GetComponent<InteractiveObject>();
                    io.StartAction();
                }
            }
        }
    }
    void ClampXAxisRotToValue(float value)
    {
        Vector3 eulerRotation = transform.eulerAngles;
        eulerRotation.x = value;
        transform.eulerAngles = eulerRotation;
    }
}
