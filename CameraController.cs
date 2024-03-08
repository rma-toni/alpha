using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        cameraMovement();
    }

    void cameraMovement()
    {
        float MouseY = Input.GetAxis("Mouse Y");
        if (transform.rotation.x >= -0.15f && transform.rotation.x < 0.075f)
        {
            Debug.Log("En if principal");
            transform.Rotate(new Vector3(-MouseY, 0f, 0f));
        } else if (transform.rotation.x < -0.15f)
        {
            Debug.Log("En if arriba");
            if (MouseY < 0)
            {
                transform.Rotate(new Vector3(-MouseY, 0f, 0f));
            }
        } else if (transform.rotation.x > 0.075f)
        {
            Debug.Log("En if abajo");
            if (MouseY > 0) {
                transform.Rotate(new Vector3(-MouseY, 0f, 0f));
            }
        }
    }
}
