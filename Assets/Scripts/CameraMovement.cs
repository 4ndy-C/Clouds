using System.Collections;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float sens = 100f; 
    public float speed = 20f; 
    public Transform controller; 

    private float xRotation = 0f; 

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; 
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal"); 
        float z = Input.GetAxis("Vertical"); 

        Vector3 move = new Vector3(x, 0, z); 
        transform.Translate(move * speed * Time.deltaTime); 

        float mouseX = Input.GetAxis("Mouse X") * sens * Time.deltaTime; 
        float mouseY = Input.GetAxis("Mouse Y") * sens * Time.deltaTime; 

        //xRotation -= mouseY; 
        //xRotation = Mathf.Clamp(xRotation, -90f, 90f);  

        //transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); 
        controller.Rotate(Vector3.up * mouseX); 
        controller.Rotate(Vector3.left * mouseY);
        //controller.Rotate(Vector3.forward * 0); 
    }
}