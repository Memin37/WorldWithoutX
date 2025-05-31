using UnityEngine;

public class CameraControl : MonoBehaviour
{

    float rotationY = 0;
    float rotationX = 0;
    float sensitivity = 3f;

    public float rotX = 60f; // sað-sol bakýþ limiti
    public float rotY = 90f; // aþaðý-yukarý bakýþ limiti


    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;   
    }
    void Update()
    {
        rotationX += Input.GetAxis("Mouse Y") * -1 * sensitivity;
        rotationY += Input.GetAxis("Mouse X") * sensitivity;
        
        rotationX = Mathf.Clamp(rotationX, -rotX, rotX);
        rotationY = Mathf.Clamp(rotationY, -rotY, rotY);
        
        transform.localEulerAngles = new Vector3 (rotationX, rotationY, 0);


    }
}
