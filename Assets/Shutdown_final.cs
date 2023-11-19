using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shutdown_final : MonoBehaviour
{
    // Start is called before the first frame update
    public Canvas canvasToHide;
    
    void Start()
    {
        canvasToHide = GameObject.Find("Canvas_desktop_1").GetComponent<Canvas>();
    }

    
    public void closecanvas()
    {
        canvasToHide.gameObject.SetActive(false);
    }


    public void shutdown()
    {
        closecanvas();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
