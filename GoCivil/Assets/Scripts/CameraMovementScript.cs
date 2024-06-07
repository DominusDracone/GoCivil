using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementScript : MonoBehaviour
{
    public float speed;

    private Vector3 cameraPosition;
    // Start is called before the first frame update
    void Start()
    {
        cameraPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            cameraPosition.z += speed / 10;
        }
        if (Input.GetKey(KeyCode.S))
        {
            cameraPosition.z -= speed/10;
        }
        if (Input.GetKey(KeyCode.D))
        {
            cameraPosition.x += speed / 10;
        }
        if (Input.GetKey(KeyCode.A))
        {
            cameraPosition.x -= speed / 10;
        }

        transform.position = cameraPosition;
    }
}
