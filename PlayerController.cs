using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float movementSpeed = 5.0f;
    private float sensitivity = 1;

    // Start is called before the first frame update
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        playerMovement();
        cameraMovement();
    }

    void playerMovement()
    {
        if (Input.GetKey("w"))
        {
            transform.position = transform.position + new Vector3(0,0,movementSpeed*Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            transform.position = transform.position + new Vector3(0,0,-movementSpeed*Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            transform.position = transform.position + new Vector3(-movementSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            transform.position = transform.position + new Vector3(movementSpeed * Time.deltaTime, 0, 0);
        }
    }

    void cameraMovement()
    {
        if (Input.GetKey("r"))
        {
            Debug.Log("Se presiono la tecla de rotacion");
        }
    }
}
