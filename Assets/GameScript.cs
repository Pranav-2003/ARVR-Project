using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotationSpeed = 0.3f; // Rotation speed
    public float translationSpeed = 1000.0f; // Translation (movement) speed
    public Canvas canvasToHide;
    public float newWidth = 1000.0f; // Set your desired width
    public float newHeight = 800.0f;

    void opencanvas()
    {
        canvasToHide.gameObject.SetActive(true);
    }
    void closecanvas()
    {
        canvasToHide.gameObject.SetActive(false);
    }
    void Start()
    {
        canvasToHide = GameObject.Find("Canvas").GetComponent<Canvas>();
        closecanvas();

        RectTransform rectTransform = canvasToHide.GetComponent<RectTransform>();
        rectTransform.sizeDelta = new Vector2(newWidth, newHeight);
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

        if (Input.GetMouseButtonDown(0)) // Left mouse button click
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                GameObject clickedObject = hit.collider.gameObject;
                
                if (clickedObject.name == "Computer_1" || clickedObject.name == "Computer.001_1" || clickedObject.name == "Computer.003_1") // Replace "YourTag" with the desired tag
                {
                    opencanvas();
                }
                Debug.Log("Clicked Object: " + clickedObject.name);
            }
        }

        

    }
}
