using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectorAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 500.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("u") || Input.GetKey(KeyCode.U))
        {
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey("j") || Input.GetKey(KeyCode.J))
        {
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }
    }
}
