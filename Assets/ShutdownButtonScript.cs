using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShutdownButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Canvas canvasToHide_1;
    public Canvas canvasToHide_2;
    
    public void closecanvas()
    {
        canvasToHide_1.gameObject.SetActive(false);
        canvasToHide_2.gameObject.SetActive(false);
    }

    void Start()
    {
        canvasToHide_1 = GameObject.Find("Canvas").GetComponent<Canvas>();
        canvasToHide_2 = GameObject.Find("Canvas_desktop").GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
