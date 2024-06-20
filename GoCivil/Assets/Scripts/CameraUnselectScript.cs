using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraUnselectScript : MonoBehaviour
{
    public GameObject plotMenu;

    private Ray zrak;
    private RaycastHit meta;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            zrak = GetComponent<Camera> ().ScreenPointToRay(Input.mousePosition);
            if (!Physics.Raycast(zrak, out meta, 1000f))
            {
                Debug.Log("Nije meta");
                plotMenu.GetComponent<PlotMenuScript>().Deselect();
            }
        }
    }
}
