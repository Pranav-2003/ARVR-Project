using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Canvas canvasToHide_1;
    public Canvas canvasToHide_2;
    public Canvas canvasToHide_3;
    
    void Start()
    {
        canvasToHide_1 = GameObject.Find("Canvas").GetComponent<Canvas>();
        canvasToHide_2 = GameObject.Find("Canvas_desktop").GetComponent<Canvas>();
        canvasToHide_3 = GameObject.Find("Canvas_desktop_1").GetComponent<Canvas>();
    }

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

    public void logincanvas()
    {
        opencanvas_2();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
