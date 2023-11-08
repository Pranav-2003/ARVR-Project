using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Canvas canvasToHide;
    public void closecanvas()
    {
        canvasToHide.gameObject.SetActive(false);
    }

    void Start()
    {
        canvasToHide = GameObject.Find("Canvas").GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    
}
