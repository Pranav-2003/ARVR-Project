using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 500.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("o") || Input.GetKey(KeyCode.O))
        {
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey("c") || Input.GetKey(KeyCode.C))
        {
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }
    }
}
