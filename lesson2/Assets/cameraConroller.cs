using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraConroller : MonoBehaviour
{
    float mouseX;
    float mouseY;
    [Header("Чувствительность")]
    public float sensivity = 120f;
    public Transform Player;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        mouseX = Input.GetAxis("mouseX") * sensivity * Time.deltaTime;
        mouseY = Input.GetAxis("mouseY") * sensivity * Time.deltaTime;

        Player.Rotate(mouseX * new Vector3(0, 1, 0));

        transform.Rotate(-mouseY * new Vector3(1, 0, 0));
    }
}
