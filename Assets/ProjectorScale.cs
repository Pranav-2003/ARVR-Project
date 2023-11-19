using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectorScale : MonoBehaviour
{
    // Start is called before the first frame update
   
    public float moveSpeed = 460.0f;
    public float incrementAmount = 0.000045f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("u") || Input.GetKey(KeyCode.U))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            Vector3 currentScale = transform.localScale;
            currentScale.x -= incrementAmount;
            transform.localScale = currentScale;
        }
        if (Input.GetKey("j") || Input.GetKey(KeyCode.J))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            Vector3 currentScale = transform.localScale;
            currentScale.x += incrementAmount;
            transform.localScale = currentScale;
        }
    }
}
