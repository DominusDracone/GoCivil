using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClicablePlotScript : MonoBehaviour
{
    private Ray zrak;
    private Camera kamera;
    private RaycastHit meta;
    // Start is called before the first frame update
    void Start()
    {
        kamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            zrak = kamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(zrak, out meta, 1000f))
            {
                if (meta.transform == transform)
                {
                    Debug.Log("Klikmuo");
                }
            }
        }
    }
}
