using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class correct_ans : MonoBehaviour
{
    // Start is called before the first frame update
    public Button myButton;
    public Canvas myCanvas_quiz_1;
    public Canvas myCanvas_quiz_2;

    void Start()
    {
        myButton.onClick.AddListener(OnButtonClick); 
        myCanvas_quiz_1 = GameObject.Find("Canvas_desktop").GetComponent<Canvas>(); 
        myCanvas_quiz_2 = GameObject.Find("Canvas_desktop_1").GetComponent<Canvas>();   
    }

    // Update is called once per frame
    public void OnButtonClick()
    {
        Debug.Log("option clicked");
        myButton.image.color = Color.green;
        StartCoroutine(DisableCanvasAfterDelay(2f));
    }

    void Update()
    {

    }

    private IEnumerator DisableCanvasAfterDelay(float delay)
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(delay);

        // Disable the canvas
        
        myCanvas_quiz_1.gameObject.SetActive(false);
        myCanvas_quiz_2.gameObject.SetActive(true);
    }
}
