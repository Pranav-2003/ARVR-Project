using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotationSpeed = 0.3f; // Rotation speed
    public float translationSpeed = 2500.0f; // Translation (movement) speed
  
    public Canvas canvasToHide;
    public Canvas canvasToHide_1;
    public Canvas canvasToHide_2;
    public Canvas canvasToHide_3;

    public float newWidth = 1000.0f; // Set your desired width
    public float newHeight = 800.0f;

    public void opencanvas_1()
    {
        canvasToHide_1.gameObject.SetActive(true);
        canvasToHide_2.gameObject.SetActive(false);
        canvasToHide_3.gameObject.SetActive(false);
    }
    
    public void opencanvas_2()
    {
        canvasToHide_1.gameObject.SetActive(false);
        canvasToHide_2.gameObject.SetActive(true);
        canvasToHide_3.gameObject.SetActive(false);
    }
    
    public void opencanvas_3()
    {
        canvasToHide_1.gameObject.SetActive(false);
        canvasToHide_2.gameObject.SetActive(false);
        canvasToHide_3.gameObject.SetActive(true);
    }
    
    public void closecanvas()
    {
        canvasToHide_1.gameObject.SetActive(false);
        canvasToHide_2.gameObject.SetActive(false);
        canvasToHide_3.gameObject.SetActive(false);
    }

    void Start()
    {
        canvasToHide = GameObject.Find("Canvas").GetComponent<Canvas>();
        canvasToHide_1 = GameObject.Find("Canvas").GetComponent<Canvas>();
        canvasToHide_2 = GameObject.Find("Canvas_desktop").GetComponent<Canvas>();
        canvasToHide_3 = GameObject.Find("Canvas_desktop_1").GetComponent<Canvas>();
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

        if (Input.GetKey("p") || Input.GetKey(KeyCode.P))
        {
            transform.Translate(Vector3.up * translationSpeed * Time.deltaTime);
        }
        if (Input.GetKey("l") || Input.GetKey(KeyCode.L))
        {
            transform.Translate(Vector3.down * translationSpeed * Time.deltaTime);
        }

        if (Input.GetMouseButtonDown(0)) // Left mouse button click
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                GameObject clickedObject = hit.collider.gameObject;
                
                if (clickedObject.name == "Computer_1" || clickedObject.name == "Computer.001_1" || clickedObject.name == "Computer.003_1") // Replace "YourTag" with the desired tag
                {
                    if( !(canvasToHide_1.gameObject.activeSelf) && !(canvasToHide_2.gameObject.activeSelf) && !(canvasToHide_3.gameObject.activeSelf))
                        opencanvas_1();
                }
                Debug.Log("Clicked Object: " + clickedObject.name);
            }
        }

        

    }
}
