using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float movementSpeed = 5.0f;
    //private float sensitivity = 1;

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
            transform.Translate(0, 0, movementSpeed*Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(0, 0, -movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(-movementSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(movementSpeed * Time.deltaTime, 0, 0);
        }
    }

    void cameraMovement()
    {
        float MouseX = Input.GetAxis("Mouse X");
        Debug.Log("Se presiono la tecla de rotacion");
        //transform.rotation = Quaternion.AngleAxis(MouseX, new Vector3(0,1,0));
        transform.Rotate(new Vector3(0f, MouseX, 0f));
    }
}
