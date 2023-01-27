using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouselook : MonoBehaviour
{
    public float speed = 100;
    public Transform player;
    float xRotate = 0;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        xRotate -= mouseY;
        xRotate = Mathf.Clamp(xRotate, -90, 90);
        transform.localRotation = Quaternion.Euler(xRotate, 0, 0);

        player.Rotate(Vector3.up * mouseX);
        
    }
}
