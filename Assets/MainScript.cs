using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	

public class MainScript : MonoBehaviour
{
    // Start is called before the first frame update
    
    public float rotationSpeed = 0.3f; // Rotation speed
    public float translationSpeed = 100000.0f; // Translation (movement) speed
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Translation (Movement)
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 translation = new Vector3( 0 , 0, verticalInput) * translationSpeed * Time.deltaTime;
        transform.Translate(translation, Space.Self);
        // Check for mouse input
        float mouseX = Input.GetAxis("Horizontal");
        // Rotate the camera
        transform.Rotate(Vector3.up, mouseX * rotationSpeed);
        // Optional: Ensure that the camera doesn't flip upside down
        Vector3 currentRotation = transform.rotation.eulerAngles;
        currentRotation.x = Mathf.Clamp(currentRotation.x, -90f, 90f);
        transform.rotation = Quaternion.Euler(currentRotation);
    
    }
}
