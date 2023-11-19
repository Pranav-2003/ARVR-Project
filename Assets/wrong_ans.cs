using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wrong_ans : MonoBehaviour
{
    // Start is called before the first frame update
    public Button myButton;

    void Start()
    {
        myButton.onClick.AddListener(OnButtonClick);    
    }

    // Update is called once per frame
    public void OnButtonClick()
    {
        Debug.Log("option clicked");
        myButton.image.color = Color.red;
    }

    void Update()
    {

    }
}
