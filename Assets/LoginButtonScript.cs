using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Canvas canvasToHide_1;
    public Canvas canvasToHide_2;
    
    void Start()
    {
        canvasToHide_1 = GameObject.Find("Canvas").GetComponent<Canvas>();
        canvasToHide_2 = GameObject.Find("Canvas_desktop").GetComponent<Canvas>();
    }

    public void logincanvas()
    {
        canvasToHide_1.gameObject.SetActive(false);
        canvasToHide_2.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
