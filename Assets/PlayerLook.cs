using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Camera cam;

    private float yRotation = 0f;
    private float xRotation = 0f;

    public float ySensitivity = 10f;
    public float xSensitivity = 10f;

    public void ProcessLook(Vector2 input)
    {
        float mouseX = input.x;
        float mouseY = input.y;
        yRotation -= (mouseY * Time.deltaTime) * ySensitivity;
        yRotation = Mathf.Clamp(yRotation, -80f, 80f);
        xRotation = (mouseX * Time.deltaTime) * xSensitivity;
        cam.transform.localRotation = Quaternion.Euler(yRotation, 0, 0);
        transform.Rotate(0, xRotation, 0);
    }
}
